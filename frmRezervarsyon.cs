using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmRezervarsyon : Form
    {
        private readonly User _currentUser;

        public frmRezervarsyon(User currentUser = null)
        {
            InitializeComponent();
            _currentUser = currentUser;
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        private void RezervasyonlarForm_Load(object sender, EventArgs e)
        {
            // Populate Masa Seç ComboBox
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var tables = context.RestaurantTables.OrderBy(t => t.Id).ToList();
                    cmbMasaSec.DataSource = tables;
                    cmbMasaSec.DisplayMember = "Name";
                    cmbMasaSec.ValueMember = "Id";
                }
            }
            catch (Exception)
            {
                // Fallback dummy data if DB not available
                cmbMasaSec.Items.Add("Masa 1");
                cmbMasaSec.Items.Add("Masa 2");
                cmbMasaSec.Items.Add("Masa 3");
            }

            // Populate Kişi Sayısı
            for (int i = 1; i <= 20; i++)
            {
                cmbKisiSayisi.Items.Add(i.ToString());
            }

            LoadCustomers();
        }

        private int _selectedCustomerId = 0;

        private void LoadCustomers()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var customers = context.Customers.ToList();
                    dgvMusteriler.Rows.Clear();
                    foreach (var c in customers)
                    {
                        int rowIndex = dgvMusteriler.Rows.Add(c.Name, c.Surname, c.Phone, c.Address, c.Email);
                        dgvMusteriler.Rows[rowIndex].Tag = c.Id;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvMusteriler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                var row = dgvMusteriler.SelectedRows[0];
                if (row.Tag != null)
                {
                    _selectedCustomerId = (int)row.Tag;
                    txtMusteri.Text = $"{row.Cells[0].Value} {row.Cells[1].Value}".Trim();
                    txtTelefon.Text = row.Cells[2].Value?.ToString() ?? "";
                    txtAdres.Text = row.Cells[3].Value?.ToString() ?? "";
                }
            }
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteri.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Müşteri adı ve telefonu zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtMusteri.Text.Trim();
            int spaceIndex = fullName.IndexOf(' ');
            string name = spaceIndex > -1 ? fullName.Substring(0, spaceIndex) : fullName;
            string surname = spaceIndex > -1 ? fullName.Substring(spaceIndex + 1) : "";

            using (var context = new ApplicationDbContext())
            {
                var newCustomer = new Customer
                {
                    Name = name,
                    Surname = surname,
                    Phone = txtTelefon.Text.Trim(),
                    Address = txtAdres.Text.Trim(),
                    Email = ""
                };
                context.Customers.Add(newCustomer);
                context.SaveChanges();
                MessageBox.Show("Yeni müşteri kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadCustomers();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtMusteri.Text.Trim();
            int spaceIndex = fullName.IndexOf(' ');
            string name = spaceIndex > -1 ? fullName.Substring(0, spaceIndex) : fullName;
            string surname = spaceIndex > -1 ? fullName.Substring(spaceIndex + 1) : "";

            using (var context = new ApplicationDbContext())
            {
                var c = context.Customers.Find(_selectedCustomerId);
                if (c != null)
                {
                    c.Name = name;
                    c.Surname = surname;
                    c.Phone = txtTelefon.Text.Trim();
                    c.Address = txtAdres.Text.Trim();
                    context.SaveChanges();
                    MessageBox.Show("Müşteri bilgileri güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadCustomers();
        }

        private void btnRezervasyonAc_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Lütfen rezervasyon yapılacak müşteriyi tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMasaSec.SelectedValue == null)
            {
                MessageBox.Show("Lütfen kayıtlı statüde olan bir masa seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kisiSayisi = 1;
            if (cmbKisiSayisi.SelectedItem != null)
            {
                int.TryParse(cmbKisiSayisi.SelectedItem.ToString(), out kisiSayisi);
            }

            using (var context = new ApplicationDbContext())
            {
                var rez = new Reservation
                {
                    CustomerId = _selectedCustomerId,
                    RestaurantTableId = (int)cmbMasaSec.SelectedValue,
                    ReservationDate = dtpTarih.Value,
                    NumberOfPeople = kisiSayisi,
                    Note = txtAciklama.Text.Trim()
                };
                context.Reservations.Add(rez);

                // Masayı "Rezerve" durumuna çek
                var masa = context.RestaurantTables.Find(rez.RestaurantTableId);
                if (masa != null)
                {
                    masa.Status = TableStatus.Reserved;
                }

                context.SaveChanges();
                MessageBox.Show("Rezervasyon başarıyla oluşturuldu!\n\nSeçili masa ilgili tarih için rezerve edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu(_currentUser);
            form.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
