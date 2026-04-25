using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmSettings : Form
    {
        private readonly User _currentUser;
        private int _selectedUserId = 0; // Defines which user is being edited

        public frmSettings(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        // Background circles matching the Metro design
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                // Top right circles
                g.DrawEllipse(p, this.Width - 150, -50, 200, 200);
                g.DrawEllipse(p, this.Width - 80, 50, 100, 100);
                g.DrawEllipse(p, this.Width - 200, 80, 80, 80);
                g.DrawEllipse(p, this.Width - 60, 180, 60, 60);
                
                // Bottom left circles
                g.DrawEllipse(p, -50, this.Height - 150, 180, 180);
                g.DrawEllipse(p, 50, this.Height - 80, 100, 100);
                g.DrawEllipse(p, -20, this.Height - 50, 60, 60);
                
                // Center circles
                g.DrawEllipse(p, this.Width / 2 - 100, this.Height / 2 - 100, 250, 250);
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Roles
            cmbGorevi.Items.AddRange(new string[] { "Müdür", "Şef", "Bulaşıkçı", "Garson", "Kasiyer" });
            if (cmbGorevi.Items.Count > 0) cmbGorevi.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = context.Users.ToList();

                // Fill cmbUserSelect
                cmbUserSelect.DataSource = null; // reset
                cmbUserSelect.DataSource = users;
                cmbUserSelect.DisplayMember = "Username";
                cmbUserSelect.ValueMember = "Id";

                // Fill DataGridView
                var displayData = users.Select(u => new
                {
                    u.Id,
                    Gorevi = u.Role,
                    u.FirstName,
                    u.LastName
                }).ToList();

                dgvUsers.DataSource = displayData;

                if (dgvUsers.Columns.Contains("Id"))
                    dgvUsers.Columns["Id"].Visible = false;
                if (dgvUsers.Columns.Contains("FirstName"))
                    dgvUsers.Columns["FirstName"].HeaderText = "Adı";
                if (dgvUsers.Columns.Contains("LastName"))
                    dgvUsers.Columns["LastName"].HeaderText = "Soyad";
                if (dgvUsers.Columns.Contains("Gorevi"))
                    dgvUsers.Columns["Gorevi"].HeaderText = "Görevi";
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (cmbUserSelect.SelectedItem is not User selectedUser)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtYeniSifre.Text) || string.IsNullOrWhiteSpace(txtTYeniSifre.Text))
            {
                MessageBox.Show("Lütfen yeni şifreyi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtYeniSifre.Text != txtTYeniSifre.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check permissions (Only Admin/Müdür can change someone else's password, exception yourself)
            if (_currentUser.Role != "Müdür" && _currentUser.Role != "Admin" && _currentUser.Id != selectedUser.Id)
            {
                MessageBox.Show("Başka bir kullanıcının şifresini değiştirmek için yetkiniz yok!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.Find(selectedUser.Id);
                if (user != null)
                {
                    user.Password = txtYeniSifre.Text;
                    context.SaveChanges();
                    MessageBox.Show("Şifre başarıyla değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtYeniSifre.Clear();
                    txtTYeniSifre.Clear();
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            _selectedUserId = 0;
            txtAdi.Clear();
            txtSoyad.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            cmbGorevi.SelectedIndex = 0;
            txtAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validations
            if (string.IsNullOrWhiteSpace(txtAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Adı ve Şifre alanları zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentUser.Role != "Müdür" && _currentUser.Role != "Admin")
            {
                MessageBox.Show("Yeni kullanıcı eklemek/düzenlemek için yetkiniz yok!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                if (_selectedUserId == 0)
                {
                    // Yeni Ekle
                    var newUser = new User
                    {
                        Username = txtAdi.Text.ToLower(), // basic generation
                        FirstName = txtAdi.Text,
                        LastName = txtSoyad.Text,
                        Password = txtSifre.Text,
                        Role = cmbGorevi.SelectedItem.ToString() ?? "Garson"
                    };
                    context.Users.Add(newUser);
                    MessageBox.Show("Kullanıcı eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Güncelle
                    var user = context.Users.Find(_selectedUserId);
                    if (user != null)
                    {
                        user.FirstName = txtAdi.Text;
                        user.LastName = txtSoyad.Text;
                        user.Password = txtSifre.Text;
                        user.Role = cmbGorevi.SelectedItem.ToString() ?? "Garson";
                        
                        // If current user updated themselves, update memory object too
                        if (_selectedUserId == _currentUser.Id)
                        {
                            _currentUser.FirstName = user.FirstName;
                            _currentUser.LastName = user.LastName;
                            _currentUser.Role = user.Role;
                            _currentUser.Password = user.Password;
                        }

                        MessageBox.Show("Kullanıcı güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                context.SaveChanges();
            }


            LoadData();
            btnYeni_Click(sender, e); // Alanları temizle
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0 || dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için tablodan bir kullanıcı seçin (görmek için satıra tıklayın).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_currentUser.Role != "Müdür" && _currentUser.Role != "Admin")
            {
                MessageBox.Show("Kullanıcı silmek için yetkiniz yok!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_selectedUserId == _currentUser.Id)
            {
                MessageBox.Show("Kendinizi silemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialogResult = MessageBox.Show("Seçili kullanıcıyı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = context.Users.Find(_selectedUserId);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        MessageBox.Show("Kullanıcı silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        btnYeni_Click(sender, e);
                    }
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int id = (int)dgvUsers.CurrentRow.Cells["Id"].Value;
                LoadUserToEditFields(id);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için tablodan bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadUserToEditFields(int userId)
        {
            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    _selectedUserId = user.Id;
                    txtAdi.Text = user.FirstName;
                    txtSoyad.Text = user.LastName;
                    txtSifre.Text = user.Password;
                    txtSifreTekrar.Text = user.Password;
                    cmbGorevi.SelectedItem = user.Role;
                }
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dgvUsers.Rows[e.RowIndex].Cells["Id"].Value;
                LoadUserToEditFields(id);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
