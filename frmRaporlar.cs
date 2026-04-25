using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;

namespace RestaurantOtomasyon
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        // Arka plan daireleri
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                g.DrawEllipse(p, this.Width - 150, -50, 200, 200);
                g.DrawEllipse(p, this.Width - 80, 50, 100, 100);
                g.DrawEllipse(p, this.Width - 200, 80, 80, 80);
                g.DrawEllipse(p, this.Width - 60, 180, 60, 60);

                g.DrawEllipse(p, -50, this.Height - 150, 180, 180);
                g.DrawEllipse(p, 50, this.Height - 80, 100, 100);

                g.DrawEllipse(p, this.Width / 2 - 100, this.Height / 2 - 50, 200, 200);
            }
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            // Ay listesi
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                               "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            cmbAy.Items.AddRange(aylar);
            cmbAy.SelectedIndex = DateTime.Now.Month - 1;

            // Yıl listesi
            for (int y = DateTime.Now.Year - 5; y <= DateTime.Now.Year + 1; y++)
            {
                cmbYil.Items.Add(y.ToString());
            }
            cmbYil.SelectedItem = DateTime.Now.Year.ToString();

            dgvRapor.CellPainting += dgvRapor_CellPainting;
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            if (cmbAy.SelectedIndex < 0 || cmbYil.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen ay ve yıl seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ay = cmbAy.SelectedIndex + 1;
            int yil = int.Parse(cmbYil.SelectedItem!.ToString()!);

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var items = (from oi in context.OrderItems
                                 join o in context.Orders on oi.OrderId equals o.Id
                                 join p in context.Products on oi.ProductId equals p.Id
                                 where o.OrderDate.Month == ay && o.OrderDate.Year == yil
                                 select new 
                                 { 
                                     o.Id, 
                                     o.OrderDate, 
                                     o.DiscountAmount, 
                                     ProductName = p.Name, 
                                     ProductId = p.Id,
                                     ItemPrice = oi.Price,
                                     ItemQty = oi.Quantity,
                                     OrderItems = o.OrderItems // For Sum
                                 }).ToList();

                    var raporData = items.Select(x => new RaporDto
                    {
                        ORDERID = x.Id,
                        ARATOPLAM = x.OrderItems.Sum(oi => oi.Price * oi.Quantity),
                        INDIRIM = x.DiscountAmount,
                        URUNAD = "⊞ " + x.ProductName,
                        URUNID = x.ProductId,
                        TARIH = x.OrderDate,
                        IsGap = false
                    }).ToList();
                    
                    foreach(var r in raporData)
                    {
                        decimal net = (r.ARATOPLAM ?? 0) - (r.INDIRIM ?? 0);
                        r.KDVTUTARI = net > 0 ? net * 0.08m : 0;
                        r.TOPLAMTUTAR = net + r.KDVTUTARI;
                    }

                    var rapor = new System.Collections.Generic.List<RaporDto>();
                    for (int i = 0; i < raporData.Count; i++)
                    {
                        rapor.Add(raporData[i]);
                        if (i < raporData.Count - 1 && raporData[i].ORDERID != raporData[i + 1].ORDERID)
                            rapor.Add(new RaporDto { IsGap = true });
                    }

                    dgvRapor.DataSource = rapor;
                    FormatColumns();

                    decimal totalSum = raporData.GroupBy(r => r.ORDERID).Select(g => g.First().TOPLAMTUTAR ?? 0).Sum();
                    lblRaporBaslik.Text = $"AYLIK RAPOR - {cmbAy.SelectedItem} {yil}";
                    lblToplamOzet.Text = $"Genel Toplam: {totalSum:N2} TL | Kayıt: {rapor.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            // Z Raporu - günlük kapanış raporu (bugünün verileri)
            DateTime bugun = DateTime.Today;

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var items = (from oi in context.OrderItems
                                 join o in context.Orders on oi.OrderId equals o.Id
                                 join p in context.Products on oi.ProductId equals p.Id
                                 where o.OrderDate.Date == bugun
                                 select new 
                                 { 
                                     o.Id, 
                                     o.OrderDate, 
                                     o.DiscountAmount, 
                                     ProductName = p.Name, 
                                     ProductId = p.Id,
                                     ItemPrice = oi.Price,
                                     ItemQty = oi.Quantity,
                                     OrderItems = o.OrderItems 
                                 }).ToList();

                    var raporData = items.Select(x => new RaporDto
                    {
                        ORDERID = x.Id,
                        ARATOPLAM = x.OrderItems.Sum(oi => oi.Price * oi.Quantity),
                        INDIRIM = x.DiscountAmount,
                        URUNAD = "⊞ " + x.ProductName,
                        URUNID = x.ProductId,
                        TARIH = x.OrderDate,
                        IsGap = false
                    }).ToList();
                    
                    foreach(var r in raporData)
                    {
                        decimal net = (r.ARATOPLAM ?? 0) - (r.INDIRIM ?? 0);
                        r.KDVTUTARI = net > 0 ? net * 0.08m : 0;
                        r.TOPLAMTUTAR = net + r.KDVTUTARI;
                    }

                    var rapor = new System.Collections.Generic.List<RaporDto>();
                    for (int i = 0; i < raporData.Count; i++)
                    {
                        rapor.Add(raporData[i]);
                        if (i < raporData.Count - 1 && raporData[i].ORDERID != raporData[i + 1].ORDERID)
                            rapor.Add(new RaporDto { IsGap = true });
                    }

                    dgvRapor.DataSource = rapor;
                    FormatColumns();

                    decimal totalSum = raporData.GroupBy(r => r.ORDERID).Select(g => g.First().TOPLAMTUTAR ?? 0).Sum();
                    lblRaporBaslik.Text = $"Z RAPORU - {bugun:dd.MM.yyyy}";
                    lblToplamOzet.Text = $"Genel Toplam: {totalSum:N2} TL | Kayıt: {rapor.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Z Raporu yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void FormatColumns()
        {
            if (dgvRapor.Columns.Contains("ORDERID"))
            {
                dgvRapor.Columns["ORDERID"].Visible = false;
            }
            if (dgvRapor.Columns.Contains("IsGap"))
            {
                dgvRapor.Columns["IsGap"].Visible = false;
            }
            if (dgvRapor.Columns.Contains("ARATOPLAM"))
            {
                dgvRapor.Columns["ARATOPLAM"].HeaderText = "ARATOPLAM";
                dgvRapor.Columns["ARATOPLAM"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["ARATOPLAM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["ARATOPLAM"].DefaultCellStyle.BackColor = Color.FromArgb(40, 0, 0); // Dark red tint
            }
            if (dgvRapor.Columns.Contains("KDVTUTARI"))
            {
                dgvRapor.Columns["KDVTUTARI"].HeaderText = "KDVTUTARI";
                dgvRapor.Columns["KDVTUTARI"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["KDVTUTARI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["KDVTUTARI"].DefaultCellStyle.BackColor = Color.FromArgb(50, 0, 0); // Darker red tint
            }
            if (dgvRapor.Columns.Contains("INDIRIM"))
            {
                dgvRapor.Columns["INDIRIM"].HeaderText = "INDIRIM";
                dgvRapor.Columns["INDIRIM"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["INDIRIM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["INDIRIM"].DefaultCellStyle.BackColor = Color.FromArgb(60, 0, 0); // Even darker red tint
            }
            if (dgvRapor.Columns.Contains("TOPLAMTUTAR"))
            {
                dgvRapor.Columns["TOPLAMTUTAR"].HeaderText = "TOPLAMTUTAR";
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.BackColor = Color.Black;
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.ForeColor = Color.Red;
            }
            if (dgvRapor.Columns.Contains("URUNAD"))
            {
                dgvRapor.Columns["URUNAD"].HeaderText = "URUNAD";
                dgvRapor.Columns["URUNAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvRapor.Columns["URUNAD"].DefaultCellStyle.ForeColor = Color.White;
                dgvRapor.Columns["URUNAD"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            if (dgvRapor.Columns.Contains("URUNID"))
            {
                dgvRapor.Columns["URUNID"].HeaderText = "URUNID";
                dgvRapor.Columns["URUNID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvRapor.Columns.Contains("TARIH"))
            {
                dgvRapor.Columns["TARIH"].HeaderText = "TARIH";
                dgvRapor.Columns["TARIH"].DefaultCellStyle.Format = "dd.MM.yyyy\nHH:mm:ss";
                dgvRapor.Columns["TARIH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvRapor.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvRapor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRapor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvRapor.EnableHeadersVisualStyles = false;
            dgvRapor.GridColor = Color.FromArgb(40, 40, 40);
            dgvRapor.RowTemplate.Height = 35;
            dgvRapor.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvRapor.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvRapor.DefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvRapor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var isGapCell = dgvRapor.Rows[e.RowIndex].Cells["IsGap"]?.Value as bool?;
            if (isGapCell == true)
            {
                // Boşluk satırını form arka plan rengiyle doldurarak tamamen gizle, böylece bir aralık efekti oluşsun
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), e.CellBounds);
                e.Handled = true;
                return;
            }

            string colName = dgvRapor.Columns[e.ColumnIndex].Name;
            string[] colsToMerge = { "ARATOPLAM", "KDVTUTARI", "INDIRIM", "TOPLAMTUTAR", "TARIH" };
            
            if (!colsToMerge.Contains(colName)) return;

            bool isSameAsPrevious = false;
            bool isSameAsNext = false;

            if (e.RowIndex > 0)
            {
                var prevIsGap = dgvRapor.Rows[e.RowIndex - 1].Cells["IsGap"]?.Value as bool?;
                if (prevIsGap != true) 
                {
                    var currentId = dgvRapor.Rows[e.RowIndex].Cells["ORDERID"].Value;
                    var prevId = dgvRapor.Rows[e.RowIndex - 1].Cells["ORDERID"].Value;
                    if (currentId != null && currentId.Equals(prevId))
                        isSameAsPrevious = true;
                }
            }

            if (e.RowIndex < dgvRapor.RowCount - 1)
            {
                var nextIsGap = dgvRapor.Rows[e.RowIndex + 1].Cells["IsGap"]?.Value as bool?;
                if (nextIsGap != true)
                {
                    var currentId = dgvRapor.Rows[e.RowIndex].Cells["ORDERID"].Value;
                    var nextId = dgvRapor.Rows[e.RowIndex + 1].Cells["ORDERID"].Value;
                    if (currentId != null && currentId.Equals(nextId))
                        isSameAsNext = true;
                }
            }

            // Hücre arka planını çiz (seçim renkleri vb. için)
            e.PaintBackground(e.CellBounds, true);

            using (Pen gridPen = new Pen(dgvRapor.GridColor))
            {
                // Sağ kenarlık
                e.Graphics.DrawLine(gridPen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                
                // Eğer grubun (siparişin) son satırıysa veya sonraysa alt kenarlık çiz
                if (!isSameAsNext)
                {
                    e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                }
            }

            // Metni sadece grubun ilk satırına yaz
            if (!isSameAsPrevious)
            {
                Rectangle textBounds = e.CellBounds;
                textBounds.Inflate(-2, -2);
                
                // Hücre kenarlarına hizalaması
                textBounds.Y += 5; // Üstten hafif boşluk (daha ortalanmış görünmesi için) 

                TextFormatFlags flags = TextFormatFlags.Top | TextFormatFlags.WordBreak;
                if (dgvRapor.Columns[e.ColumnIndex].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
                    flags |= TextFormatFlags.Right;
                else if (dgvRapor.Columns[e.ColumnIndex].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleCenter)
                    flags |= TextFormatFlags.HorizontalCenter;
                else
                    flags |= TextFormatFlags.Left;

                string formattedValue = e.FormattedValue?.ToString() ?? "";
                Color textColor = e.State.HasFlag(DataGridViewElementStates.Selected) ? e.CellStyle.SelectionForeColor : e.CellStyle.ForeColor;

                TextRenderer.DrawText(e.Graphics, formattedValue, e.CellStyle.Font, textBounds, textColor, flags);
            }

            e.Handled = true;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = null;
            lblRaporBaslik.Text = "Rapor seçiniz...";
            lblToplamOzet.Text = "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class RaporDto
    {
        public int? ORDERID { get; set; }
        public decimal? ARATOPLAM { get; set; }
        public decimal? KDVTUTARI { get; set; }
        public decimal? INDIRIM { get; set; }
        public decimal? TOPLAMTUTAR { get; set; }
        public string? URUNAD { get; set; }
        public int? URUNID { get; set; }
        public DateTime? TARIH { get; set; }
        public bool IsGap { get; set; }
    }
}
