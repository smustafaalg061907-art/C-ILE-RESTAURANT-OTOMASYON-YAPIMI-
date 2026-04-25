using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmLock : Form
    {
        private readonly int _tableId;
        private int _orderId;
        private decimal _totalAmount;
        private const decimal KDV_ORANI = 0.08m; // %8 KDV
        private const decimal INDIRIM_ORANI = 0.10m; // %10 indirim

        public frmLock(int tableId)
        {
            InitializeComponent();
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
            _tableId = tableId;
        }

        // Arka plan daireleri
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                // Sol alt daireler
                g.DrawEllipse(p, -60, this.Height - 100, 150, 150);
                g.DrawEllipse(p, -30, this.Height - 60, 80, 80);

                // Sağ üst daireler
                g.DrawEllipse(p, this.Width - 100, -50, 160, 160);
                g.DrawEllipse(p, this.Width - 60, -20, 90, 90);
                g.DrawEllipse(p, this.Width - 30, 30, 40, 40);
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var currentOrder = context.Orders.FirstOrDefault(o => 
                    (_tableId > 0 ? o.RestaurantTableId == _tableId : o.RestaurantTableId == null) && !o.IsCompleted);
                if (currentOrder != null)
                {
                    _orderId = currentOrder.Id;

                    var items = context.OrderItems
                        .Where(oi => oi.OrderId == _orderId)
                        .Select(oi => new
                        {
                            UrunAdi = oi.Product.Name,
                            Adet = oi.Quantity,
                            UrunId = oi.ProductId,
                            Fiyat = oi.Price,
                            SatisId = oi.Id
                        })
                        .ToList();

                    dgvOrderItems.DataSource = items;

                    if (dgvOrderItems.Columns.Contains("UrunAdi"))
                        dgvOrderItems.Columns["UrunAdi"].HeaderText = "Urun Adı";
                    if (dgvOrderItems.Columns.Contains("Adet"))
                        dgvOrderItems.Columns["Adet"].HeaderText = "Adet";
                    if (dgvOrderItems.Columns.Contains("UrunId"))
                        dgvOrderItems.Columns["UrunId"].HeaderText = "UrunId";
                    if (dgvOrderItems.Columns.Contains("Fiyat"))
                        dgvOrderItems.Columns["Fiyat"].HeaderText = "Fiyat";
                    if (dgvOrderItems.Columns.Contains("SatisId"))
                        dgvOrderItems.Columns["SatisId"].HeaderText = "SatisId";

                    lblSiparisCount.Text = _orderId.ToString();

                    _totalAmount = items.Sum(i => i.Adet * i.Fiyat);
                    UpdateOdemeBilgileri();
                }
                else
                {
                    MessageBox.Show("Ödenecek sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void UpdateOdemeBilgileri()
        {
            decimal indirim = chkIndirimUygula.Checked ? _totalAmount * INDIRIM_ORANI : 0;

            // Özel Aktivite - elle girilen indirim tutarı
            if (decimal.TryParse(txtIndirimTutari.Text, out decimal ozelIndirim))
            {
                indirim += ozelIndirim;
            }

            decimal fiyat = _totalAmount - indirim;
            if (fiyat < 0) fiyat = 0;
            decimal kdv = fiyat * KDV_ORANI;
            decimal araToplam = fiyat + kdv;

            lblIndirimValue.Text = indirim.ToString("N0");
            lblKDVValue.Text = kdv.ToString("N0");
            lblFiyatValue.Text = fiyat.ToString("N0");
            lblAraToplamValue.Text = araToplam.ToString("N0");
        }

        private void chkIndirimUygula_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOdemeBilgileri();
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            decimal indirim = chkIndirimUygula.Checked ? _totalAmount * INDIRIM_ORANI : 0;
            if (decimal.TryParse(txtIndirimTutari.Text, out decimal ozelIndirim2))
            {
                indirim += ozelIndirim2;
            }
            decimal fiyat = _totalAmount - indirim;
            if (fiyat < 0) fiyat = 0;
            decimal kdv = fiyat * KDV_ORANI;
            decimal araToplam = fiyat + kdv;

            string odemeTuru = "Nakit";
            if (rbKrediKarti.Checked) odemeTuru = "Kredi Kartı";
            else if (rbTicket.Checked) odemeTuru = "Ticket";

            string ozet = $"=== HESAP ÖZETİ ===\n\n" +
                          $"Sipariş No: {_orderId}\n" +
                          $"Toplam Fiyat: {_totalAmount:N2} TL\n" +
                          $"İndirim: {indirim:N2} TL\n" +
                          $"KDV (%8): {kdv:N2} TL\n" +
                          $"Ara Toplam: {araToplam:N2} TL\n\n" +
                          $"Ödeme Türü: {odemeTuru}";

            MessageBox.Show(ozet, "Hesap Özeti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            string odemeTuru = "Nakit";
            if (rbKrediKarti.Checked) odemeTuru = "Kredi Kartı";
            else if (rbTicket.Checked) odemeTuru = "Ticket";

            var result = MessageBox.Show(
                $"Hesap kapatılsın mı?\nÖdeme Türü: {odemeTuru}",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CompletePayment(odemeTuru);
            }
        }

        private void CompletePayment(string paymentMethod)
        {
            using (var context = new ApplicationDbContext())
            {
                var order = context.Orders.Find(_orderId);
                if (order != null)
                {
                    decimal indirim = chkIndirimUygula.Checked ? _totalAmount * INDIRIM_ORANI : 0;
                    if (decimal.TryParse(txtIndirimTutari.Text, out decimal ozelIndirim))
                    {
                        indirim += ozelIndirim;
                    }

                    order.DiscountAmount = indirim;
                    order.TotalAmount = _totalAmount;
                    order.PaymentMethod = paymentMethod;
                    order.IsCompleted = true;

                    var table = context.RestaurantTables.Find(_tableId);
                    if (table != null) table.Status = TableStatus.Empty;

                    context.SaveChanges();
                    MessageBox.Show($"Ödeme ({paymentMethod}) alındı. Masa boşaltıldı.",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
