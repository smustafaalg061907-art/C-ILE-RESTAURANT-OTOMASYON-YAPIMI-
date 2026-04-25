using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmMusteriGuncelle : Form
    {
        private readonly int? _customerId;

        public frmMusteriGuncelle(int? customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        // Arka plan daireleri (Metro style - fotoğraftaki gibi)
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                g.DrawEllipse(p, this.Width - 120, this.Height - 110, 180, 180);
                g.DrawEllipse(p, this.Width - 80, this.Height - 70, 100, 100);
                g.DrawEllipse(p, this.Width - 160, this.Height - 140, 60, 60);
            }
        }

        private void frmMusteriGuncelle_Load(object sender, EventArgs e)
        {
            if (_customerId.HasValue)
            {
                using (var context = new ApplicationDbContext())
                {
                    var customer = context.Customers.Find(_customerId.Value);
                    if (customer != null)
                    {
                        txtName.Text = customer.Name;
                        txtSurname.Text = customer.Surname;
                        txtPhone.Text = customer.Phone;
                        txtAddress.Text = customer.Address;
                        txtEmail.Text = customer.Email;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ad bilgisi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                if (_customerId.HasValue)
                {
                    var customer = context.Customers.Find(_customerId.Value);
                    if (customer != null)
                    {
                        customer.Name = txtName.Text;
                        customer.Surname = txtSurname.Text;
                        customer.Phone = txtPhone.Text;
                        customer.Address = txtAddress.Text;
                        customer.Email = txtEmail.Text;
                    }
                }
                else
                {
                    context.Customers.Add(new Customer
                    {
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text
                    });
                }
                context.SaveChanges();
            }

            MessageBox.Show("Müşteri kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
