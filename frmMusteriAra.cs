using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
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
                g.DrawEllipse(p, -60, -60, 200, 200);
                g.DrawEllipse(p, -30, -30, 140, 140);
                g.DrawEllipse(p, this.Width - 100, this.Height - 80, 150, 150);
                g.DrawEllipse(p, this.Width - 60, this.Height - 40, 80, 80);
            }
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();

            // Arama kutularına TextChanged olayı ekle
            txtAdi.TextChanged += SearchFields_TextChanged;
            txtSoyadi.TextChanged += SearchFields_TextChanged;
            txtTelefon.TextChanged += SearchFields_TextChanged;
            txtAdres.TextChanged += SearchFields_TextChanged;
            txtEMail.TextChanged += SearchFields_TextChanged;
        }

        private void LoadCustomers()
        {
            using (var context = new ApplicationDbContext())
            {
                var customers = context.Customers
                    .Select(c => new
                    {
                        c.Id,
                        Adi = c.Name,
                        Soyadi = c.Surname,
                        Telefon = c.Phone,
                        Adres = c.Address,
                        EMail = c.Email
                    })
                    .ToList();

                dgvCustomers.DataSource = customers;

                if (dgvCustomers.Columns.Contains("Id"))
                    dgvCustomers.Columns["Id"].Visible = false;
                if (dgvCustomers.Columns.Contains("Adi"))
                    dgvCustomers.Columns["Adi"].HeaderText = "Adı";
                if (dgvCustomers.Columns.Contains("Soyadi"))
                    dgvCustomers.Columns["Soyadi"].HeaderText = "Soyadı";
                if (dgvCustomers.Columns.Contains("EMail"))
                    dgvCustomers.Columns["EMail"].HeaderText = "E-Mail";
            }
        }

        private void SearchFields_TextChanged(object? sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var query = context.Customers.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtAdi.Text))
                    query = query.Where(c => c.Name.Contains(txtAdi.Text));
                if (!string.IsNullOrWhiteSpace(txtSoyadi.Text))
                    query = query.Where(c => c.Surname.Contains(txtSoyadi.Text));
                if (!string.IsNullOrWhiteSpace(txtTelefon.Text))
                    query = query.Where(c => c.Phone.Contains(txtTelefon.Text));
                if (!string.IsNullOrWhiteSpace(txtAdres.Text))
                    query = query.Where(c => c.Address.Contains(txtAdres.Text));

                dgvCustomers.DataSource = query
                    .Select(c => new
                    {
                        c.Id,
                        Adi = c.Name,
                        Soyadi = c.Surname,
                        Telefon = c.Phone,
                        Adres = c.Address,
                        EMail = c.Email
                    })
                    .ToList();

                if (dgvCustomers.Columns.Contains("Id"))
                    dgvCustomers.Columns["Id"].Visible = false;
            }
        }

        private void btnAdisyonBul_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAdisyonId.Text, out int adisyonId))
            {
                MessageBox.Show("Geçerli bir Adisyon ID girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var order = context.Orders.Find(adisyonId);
                if (order != null)
                {
                    var items = context.OrderItems
                        .Where(oi => oi.OrderId == adisyonId)
                        .Select(oi => $"{oi.Product.Name} x{oi.Quantity} = {oi.Price * oi.Quantity:N2} TL")
                        .ToList();

                    var table = context.RestaurantTables.Find(order.RestaurantTableId);
                    string detail = $"Adisyon #{adisyonId}\n" +
                                    $"Masa: {table?.Name}\n" +
                                    $"Tarih: {order.OrderDate:dd.MM.yyyy}\n" +
                                    $"Durum: {(order.IsCompleted ? "Tamamlandı" : "Açık")}\n\n" +
                                    string.Join("\n", items);

                    txtDetailBox.Text = detail;
                }
                else
                {
                    txtDetailBox.Text = "Adisyon bulunamadı!";
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Lütfen en azından Adı alanını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var newCustomer = new Customer
                {
                    Name = txtAdi.Text.Trim(),
                    Surname = txtSoyadi.Text.Trim(),
                    Phone = txtTelefon.Text.Trim(),
                    Address = txtAdres.Text.Trim(),
                    Email = txtEMail.Text.Trim()
                };
                context.Customers.Add(newCustomer);
                context.SaveChanges();
            }

            // Alanları temizle ve listeyi yenile
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtEMail.Clear();
            LoadCustomers();

            MessageBox.Show("Yeni müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;
                using (var context = new ApplicationDbContext())
                {
                    var customer = context.Customers.Find(id);
                    if (customer != null)
                    {
                        txtDetailBox.Text = $"Seçilen Müşteri:\n\n" +
                                            $"Adı: {customer.Name}\n" +
                                            $"Soyadı: {customer.Surname}\n" +
                                            $"Telefon: {customer.Phone}\n" +
                                            $"Adres: {customer.Address}\n" +
                                            $"E-Mail: {customer.Email}";
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;
                var frm = new frmMusteriGuncelle(id);
                frm.FormClosed += (s, args) => LoadCustomers();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Güncellemek için bir müşteri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            /*
            if (dgvCustomers.CurrentRow != null)
            {
                int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;
                var frm = new CustomerOrdersForm(id);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sipariş geçmişini görmek için bir müşteri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
            MessageBox.Show("Bu modül şu anda aktif değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
