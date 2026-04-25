using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        // Arka plan daireleri - sadece çalışma zamanında çizilir
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                // Sol üst daireler
                g.DrawEllipse(p, -50, -50, 200, 200);
                g.DrawEllipse(p, -20, -20, 140, 140);
                g.DrawEllipse(p, 30, 30, 40, 40);

                // Sağ üst daireler
                g.DrawEllipse(p, this.Width - 150, -80, 250, 250);
                g.DrawEllipse(p, this.Width - 100, -30, 150, 150);
                g.DrawEllipse(p, this.Width - 50, 60, 50, 50);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var userList = context.Users.ToList();
                cmbUsername.DataSource = userList;
                cmbUsername.DisplayMember = "Username";
                cmbUsername.ValueMember = "Id";
                if (userList.Any())
                {
                    cmbUsername.SelectedIndex = 0;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var selectedUser = cmbUsername.SelectedItem as User;
            string password = txtPassword.Text;

            if (selectedUser == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == selectedUser.Id && u.Password == password);
                if (user != null)
                {
                    var dashboard = new frmMenu(user);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifreniz yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifre sıfırlama işlemi için lütfen yönetici (Mustafa) ile iletişime geçiniz.", "Şifremi Unuttum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
