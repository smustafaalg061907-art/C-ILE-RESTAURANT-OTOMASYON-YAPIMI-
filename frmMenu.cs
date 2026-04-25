using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmMenu : Form
    {
        private readonly User _currentUser;

        public frmMenu(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this.WindowState = FormWindowState.Maximized;
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Kullanıcı: {_currentUser.Username}";
            CenterDashboard();
        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            CenterDashboard();
        }

        private void CenterDashboard()
        {
            pnlDashboard.Left = (this.ClientSize.Width - pnlDashboard.Width) / 2;
            pnlDashboard.Top = (this.ClientSize.Height - pnlDashboard.Height) / 2;
            
            pnlControlBox.Left = this.ClientSize.Width - pnlControlBox.Width - 10;
            pnlControlBox.Top = 10;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            var frm = new frmMasalar(_currentUser);
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            var frm = new frmMusteriAra();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            var login = new frmGiris();
            login.Show();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            var frm = new frmSettings(_currentUser);
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            var frm = new frmMutfak();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            var frm = new frmRaporlar();
            frm.Show();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            // Paket servis için özel bir Masa ID (örneğin 999) kullanılabilir veya farklı bir form.
            // Şimdilik mevcut sipariş formunu paket modu gibi açalım.
            var frm = new frmPaketSiparis(0, _currentUser); // 0 = Paket Servis
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            var frm = new SatisRaporlariForm();
            frm.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervarsyon(_currentUser);
            frm.Show();
        }



        // Other buttons can be wired up later
        private void btnNotImplemented_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu modül şu anda aktif değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
