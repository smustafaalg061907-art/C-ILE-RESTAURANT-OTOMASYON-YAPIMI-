using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmMutfak : Form
    {
        private int _selectedProductId = 0;

        public frmMutfak()
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
                // Sol üst daireler
                g.DrawEllipse(p, -60, -60, 200, 200);
                g.DrawEllipse(p, -30, -30, 140, 140);

                // Sağ üst daireler
                g.DrawEllipse(p, this.Width - 150, -50, 200, 200);
                g.DrawEllipse(p, this.Width - 80, 50, 100, 100);
                g.DrawEllipse(p, this.Width - 200, 80, 80, 80);

                // Sol alt daireler
                g.DrawEllipse(p, -50, this.Height - 150, 180, 180);
                g.DrawEllipse(p, 50, this.Height - 80, 100, 100);

                // Sağ alt daireler
                g.DrawEllipse(p, this.Width - 120, this.Height - 120, 160, 160);
                g.DrawEllipse(p, this.Width - 60, this.Height - 60, 80, 80);

                // Merkez daireler
                g.DrawEllipse(p, this.Width / 2 - 100, this.Height / 2 - 100, 250, 250);
            }
        }

        private void MutfakForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            using (var context = new ApplicationDbContext())
            {
                var categories = context.Categories.ToList();

                cmbGidaKategorisi.DataSource = null;
                cmbGidaKategorisi.Items.Clear();

                // "Tüm Kategoriler" seçeneği
                cmbGidaKategorisi.Items.Add("Tüm Kategoriler");
                foreach (var cat in categories)
                {
                    cmbGidaKategorisi.Items.Add(cat);
                }

                cmbGidaKategorisi.DisplayMember = "Name";
                cmbGidaKategorisi.SelectedIndex = 0;
            }
        }

        private void LoadProducts(string? searchName = null, int? categoryId = null)
        {
            using (var context = new ApplicationDbContext())
            {
                var query = context.Products
                    .Join(context.Categories,
                        p => p.CategoryId,
                        c => c.Id,
                        (p, c) => new
                        {
                            p.Id,
                            Kategori = c.Name,
                            UrunAdi = p.Name,
                            Fiyat = p.Price
                        });

                if (categoryId.HasValue && categoryId.Value > 0)
                {
                    var catName = context.Categories.Find(categoryId.Value)?.Name;
                    if (catName != null)
                        query = query.Where(x => x.Kategori == catName);
                }

                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    query = query.Where(x => x.UrunAdi.Contains(searchName));
                }

                var data = query.ToList();
                dgvUrunler.DataSource = data;

                if (dgvUrunler.Columns.Contains("Id"))
                    dgvUrunler.Columns["Id"].Visible = false;
                if (dgvUrunler.Columns.Contains("Kategori"))
                    dgvUrunler.Columns["Kategori"].HeaderText = "Kategori";
                if (dgvUrunler.Columns.Contains("UrunAdi"))
                    dgvUrunler.Columns["UrunAdi"].HeaderText = "Urun Adı";
                if (dgvUrunler.Columns.Contains("Fiyat"))
                    dgvUrunler.Columns["Fiyat"].HeaderText = "Fiyat";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGidaAdi.Text))
            {
                MessageBox.Show("Lütfen gıda adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGidaFiyati.Text, out decimal fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCat = cmbGidaKategorisi.SelectedItem as Category;
            if (selectedCat == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin! ('Tüm Kategoriler' seçilemez)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var product = new Product
                {
                    Name = txtGidaAdi.Text.Trim(),
                    Price = fiyat,
                    CategoryId = selectedCat.Id
                };
                context.Products.Add(product);
                context.SaveChanges();
            }

            MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadProducts();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == 0)
            {
                MessageBox.Show("Lütfen tablodan güncellemek istediğiniz ürünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGidaAdi.Text))
            {
                MessageBox.Show("Lütfen gıda adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGidaFiyati.Text, out decimal fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCat = cmbGidaKategorisi.SelectedItem as Category;
            if (selectedCat == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var product = context.Products.Find(_selectedProductId);
                if (product != null)
                {
                    product.Name = txtGidaAdi.Text.Trim();
                    product.Price = fiyat;
                    product.CategoryId = selectedCat.Id;
                    context.SaveChanges();
                    MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ClearFields();
            LoadProducts();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int? catId = null;
            var selectedCat = cmbGidaKategorisi.SelectedItem as Category;
            if (selectedCat != null)
                catId = selectedCat.Id;

            LoadProducts(txtGidaAdi.Text.Trim(), catId);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == 0)
            {
                MessageBox.Show("Lütfen tablodan silmek istediğiniz ürünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var context = new ApplicationDbContext())
                {
                    var product = context.Products.Find(_selectedProductId);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        MessageBox.Show("Ürün başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ClearFields();
                LoadProducts();
            }
        }

        private void btnUrunKategoriEkle_Click(object sender, EventArgs e)
        {
            // Basit bir input dialog oluştur
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Kategori Ekle";
                inputForm.Size = new Size(350, 180);
                inputForm.StartPosition = FormStartPosition.CenterParent;
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.MaximizeBox = false;
                inputForm.MinimizeBox = false;
                inputForm.BackColor = Color.FromArgb(43, 43, 43);

                Label lbl = new Label() { Text = "Yeni kategori adını girin:", Left = 20, Top = 20, Width = 290, ForeColor = Color.White, Font = new Font("Segoe UI", 10F) };
                TextBox txt = new TextBox() { Left = 20, Top = 50, Width = 290, Font = new Font("Segoe UI", 11F) };
                Button btnOk = new Button() { Text = "EKLE", Left = 130, Top = 95, Width = 90, Height = 35, BackColor = Color.FromArgb(0, 163, 0), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                Button btnCancel = new Button() { Text = "İPTAL", Left = 225, Top = 95, Width = 90, Height = 35, BackColor = Color.Red, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
                btnOk.FlatAppearance.BorderSize = 0;
                btnCancel.FlatAppearance.BorderSize = 0;

                btnOk.Click += (s, args) => { inputForm.DialogResult = DialogResult.OK; inputForm.Close(); };
                btnCancel.Click += (s, args) => { inputForm.DialogResult = DialogResult.Cancel; inputForm.Close(); };

                inputForm.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
                inputForm.AcceptButton = btnOk;
                inputForm.CancelButton = btnCancel;

                if (inputForm.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(txt.Text))
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var random = new Random();
                        string colorHex = $"#{random.Next(0x1000000):X6}";

                        var category = new Category
                        {
                            Name = txt.Text.Trim().ToUpper(),
                            ColorHex = colorHex
                        };
                        context.Categories.Add(category);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Kategori başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                }
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedProductId = (int)dgvUrunler.Rows[e.RowIndex].Cells["Id"].Value;
                txtGidaAdi.Text = dgvUrunler.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();
                txtGidaFiyati.Text = dgvUrunler.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString();

                // Kategoriyi seç
                string kategori = dgvUrunler.Rows[e.RowIndex].Cells["Kategori"].Value.ToString() ?? "";
                for (int i = 0; i < cmbGidaKategorisi.Items.Count; i++)
                {
                    if (cmbGidaKategorisi.Items[i] is Category cat && cat.Name == kategori)
                    {
                        cmbGidaKategorisi.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadCategories();
            LoadProducts();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            _selectedProductId = 0;
            txtGidaAdi.Clear();
            txtGidaFiyati.Clear();
            if (cmbGidaKategorisi.Items.Count > 0)
                cmbGidaKategorisi.SelectedIndex = 0;
        }
    }
}
