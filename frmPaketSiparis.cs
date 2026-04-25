using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmPaketSiparis : Form
    {
        private readonly int _tableId;
        private readonly User _currentUser;

        public frmPaketSiparis(int tableId, User currentUser)
        {
            InitializeComponent();
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
            _tableId = tableId;
            _currentUser = currentUser;
        }

        // ========== BACKGROUND CIRCLES ==========
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                // Top-left circles
                g.DrawEllipse(p, -60, -60, 200, 200);
                g.DrawEllipse(p, -30, -30, 140, 140);
                g.DrawEllipse(p, 20, 20, 50, 50);

                // Top-right circles
                g.DrawEllipse(p, this.Width - 120, -60, 200, 200);
                g.DrawEllipse(p, this.Width - 80, -20, 120, 120);
                g.DrawEllipse(p, this.Width - 40, 50, 50, 50);

                // Bottom-right
                g.DrawEllipse(p, this.Width - 100, this.Height - 80, 150, 150);
            }
        }

        // ========== FORM LOAD ==========
        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Encoding hatalarını önlemek için buton Tag'lerini ve Text'lerini dinamik düzeltiyoruz
            btnCatAnayemek.Tag = "ANAYEMEK"; btnCatAnayemek.Text = "ANA YEMEK";
            btnCatIcecekler.Tag = "İÇECEKLER"; btnCatIcecekler.Text = "İÇECEKLER";
            btnCatTatlilar.Tag = "TATLILAR"; btnCatTatlilar.Text = "TATLILAR";
            btnCatSalata.Tag = "SALATA"; btnCatSalata.Text = "SALATA";
            btnCatFastfood.Tag = "FASTFOOD"; btnCatFastfood.Text = "FAST FOOD";
            btnCatCorba.Tag = "ÇORBA"; btnCatCorba.Text = "ÇORBA";
            btnCatMakarna.Tag = "MAKARNA"; btnCatMakarna.Text = "MAKARNA";
            btnCatArasicak.Tag = "ARASICAK"; btnCatArasicak.Text = "ARA SICAK";

            using (var context = new ApplicationDbContext())
            {
                if (_tableId > 0)
                {
                    var table = context.RestaurantTables.Find(_tableId);
                    lblTableInfo.Text = table != null ? $"MASA {table.Name}" : "Masa Bulunamadı";
                }
                else
                {
                    lblTableInfo.Text = "PAKET SERVİS";
                }
            }

            LoadOrderItems();
        }

        // ========== GERİ BUTTON ==========
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ========== CATEGORY BUTTON CLICK ==========
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string categoryName)
            {
                using (var context = new ApplicationDbContext())
                {
                    var products = context.Products
                        .Where(p => p.Category.Name.ToUpper() == categoryName.ToUpper())
                        .Select(p => new { p.Id, UrunAdi = p.Name, UrunFiyati = p.Price })
                        .ToList();

                    dgvMenuItems.DataSource = products;

                    if (dgvMenuItems.Columns.Contains("Id"))
                        dgvMenuItems.Columns["Id"].Visible = false;

                    if (dgvMenuItems.Columns.Contains("UrunAdi"))
                        dgvMenuItems.Columns["UrunAdi"].HeaderText = "Ürün Adı";

                    if (dgvMenuItems.Columns.Contains("UrunFiyati"))
                        dgvMenuItems.Columns["UrunFiyati"].HeaderText = "Ürün Fiyatı";
                }
            }
        }

        // ========== NUMPAD CLICK ==========
        private void NumPad_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is string val)
            {
                if (val == "C")
                {
                    txtUrunNo.Text = "";
                }
                else
                {
                    txtUrunNo.Text += val;
                }
            }
        }

        // ========== MENÜ GRID DOUBLE CLICK -> SİPARİŞ EKLE ==========
        private void dgvMenuItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMenuItems.Rows[e.RowIndex];
            int productId = (int)row.Cells["Id"].Value;

            int quantity = 1;
            if (int.TryParse(txtUrunNo.Text, out int parsedQty) && parsedQty > 0)
            {
                quantity = parsedQty;
            }

            AddProductToOrder(productId, quantity);
            txtUrunNo.Text = "";
        }

        // ========== SİPARİŞ BUTTON ==========
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            int productId = 0;
            int quantity = 1;

            if (dgvMenuItems.SelectedRows.Count > 0)
            {
                // Menüden bir satır seçilmişse, onu alalım
                var row = dgvMenuItems.SelectedRows[0];
                if (row.Cells["Id"].Value != null)
                {
                    productId = (int)row.Cells["Id"].Value;
                }

                // Eğer TextBox doluysa, bunu miktar olarak kabul edelim
                if (int.TryParse(txtUrunNo.Text, out int parsedQty) && parsedQty > 0)
                {
                    quantity = parsedQty;
                }
            }
            else
            {
                // Seçim yoksa, doğrudan ürün numarası (ID) girilmiş olabilir (ID ile hızlı sipariş)
                if (int.TryParse(txtUrunNo.Text, out int parsedId) && parsedId > 0)
                {
                    productId = parsedId;
                }
            }

            if (productId > 0)
            {
                AddProductToOrder(productId, quantity);
                txtUrunNo.Text = ""; // Kutu temizlensin
            }
            else
            {
                MessageBox.Show("Lütfen menüden bir ürün seçin veya geçerli bir Numara girin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ========== ADD PRODUCT TO ORDER ==========
        private void AddProductToOrder(int productId, int quantity)
        {
            using (var context = new ApplicationDbContext())
            {
                var product = context.Products.Find(productId);
                if (product == null)
                {
                    MessageBox.Show("Ürün bulunamadı!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var currentOrder = context.Orders.FirstOrDefault(o => 
                    (_tableId > 0 ? o.RestaurantTableId == _tableId : o.RestaurantTableId == null) && !o.IsCompleted);
                if (currentOrder == null)
                {
                    currentOrder = new Order
                    {
                        RestaurantTableId = _tableId > 0 ? _tableId : (int?)null,
                        OrderDate = DateTime.Now,
                        IsCompleted = false,
                        UserId = _currentUser.Id > 0 ? _currentUser.Id : (int?)null
                    };
                    context.Orders.Add(currentOrder);

                    var table = context.RestaurantTables.Find(_tableId);
                    if (table != null) table.Status = TableStatus.Occupied;

                    context.SaveChanges();
                }

                var existingItem = context.OrderItems.FirstOrDefault(oi => oi.OrderId == currentOrder.Id && oi.ProductId == productId);
                if (existingItem != null)
                {
                    existingItem.Quantity += quantity;
                }
                else
                {
                    context.OrderItems.Add(new OrderItem
                    {
                        OrderId = currentOrder.Id,
                        ProductId = productId,
                        Quantity = quantity,
                        Price = product.Price
                    });
                }
                context.SaveChanges();
            }

            LoadOrderItems();
        }

        // ========== LOAD ORDER ITEMS ==========
        private void LoadOrderItems()
        {
            using (var context = new ApplicationDbContext())
            {
                var currentOrder = context.Orders.FirstOrDefault(o => 
                    (_tableId > 0 ? o.RestaurantTableId == _tableId : o.RestaurantTableId == null) && !o.IsCompleted);
                if (currentOrder != null)
                {
                    var items = context.OrderItems
                        .Where(oi => oi.OrderId == currentOrder.Id)
                        .Select(oi => new
                        {
                            UrunAdi = oi.Product.Name,
                            UrunAdet = oi.Quantity,
                            UrunId = oi.ProductId,
                            UrunFiyat = oi.Price
                        })
                        .ToList();

                    dgvOrderItems.DataSource = items;

                    if (dgvOrderItems.Columns.Contains("UrunAdi"))
                        dgvOrderItems.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                    if (dgvOrderItems.Columns.Contains("UrunAdet"))
                        dgvOrderItems.Columns["UrunAdet"].HeaderText = "Ürün Adet";
                    if (dgvOrderItems.Columns.Contains("UrunId"))
                        dgvOrderItems.Columns["UrunId"].HeaderText = "UrunId";
                    if (dgvOrderItems.Columns.Contains("UrunFiyat"))
                        dgvOrderItems.Columns["UrunFiyat"].HeaderText = "Urun Fiyat";
                }
                else
                {
                    dgvOrderItems.DataSource = null;

                    if (_tableId > 0)
                    {
                        var table = context.RestaurantTables.Find(_tableId);
                        if (table != null && table.Status == TableStatus.Occupied)
                        {
                            table.Status = TableStatus.Empty;
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        // ========== İPTAL BUTTON ==========
        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count == 0)
            {
                // Close form if nothing selected
                this.Close();
                return;
            }

            var selectedRow = dgvOrderItems.SelectedRows[0];
            int productId = (int)selectedRow.Cells["UrunId"].Value;

            using (var context = new ApplicationDbContext())
            {
                var currentOrder = context.Orders.FirstOrDefault(o => 
                    (_tableId > 0 ? o.RestaurantTableId == _tableId : o.RestaurantTableId == null) && !o.IsCompleted);
                if (currentOrder != null)
                {
                    var item = context.OrderItems.FirstOrDefault(oi => oi.OrderId == currentOrder.Id && oi.ProductId == productId);
                    if (item != null)
                    {
                        context.OrderItems.Remove(item);
                        context.SaveChanges();
                    }
                }
            }

            LoadOrderItems();
        }

        // ========== ÖDEME BUTTON ==========
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            var frm = new frmLock(_tableId);
            frm.ShowDialog();
            LoadOrderItems();
        }

        // ========== PAINT HANDLERS FOR ICONS ==========
        private void btnOdeme_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int iconSize = 22;
            int x = 15;
            int y = (btnOdeme.Height - iconSize) / 2;

            using (Pen pen = new Pen(Color.White, 3))
            {
                // Draw checkmark inside circle
                g.DrawEllipse(pen, x, y, iconSize, iconSize);

                Point[] pts = {
                    new Point(x + 5, y + iconSize / 2),
                    new Point(x + iconSize / 2 - 1, y + iconSize - 5),
                    new Point(x + iconSize - 2, y + 4)
                };
                g.DrawLines(pen, pts);
            }
        }

        private void btnSiparis_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int x = 15;
            int y = (btnSiparis.Height - 28) / 2;

            using (Pen pen = new Pen(Color.White, 2))
            {
                // Draw document icon
                g.DrawRectangle(pen, x, y, 18, 26);
                g.DrawLine(pen, x + 4, y + 7, x + 14, y + 7);
                g.DrawLine(pen, x + 4, y + 12, x + 14, y + 12);
                g.DrawLine(pen, x + 4, y + 17, x + 14, y + 17);
            }
        }

        private void btnIptal_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int iconSize = 28;
            int x = 20;
            int y = (btnIptal.Height - iconSize) / 2;

            using (Pen pen = new Pen(Color.White, 3))
            {
                // Draw gear-like circle with X
                g.DrawEllipse(pen, x, y, iconSize, iconSize);

                // X inside
                int pad = 8;
                g.DrawLine(pen, x + pad, y + pad, x + iconSize - pad, y + iconSize - pad);
                g.DrawLine(pen, x + iconSize - pad, y + pad, x + pad, y + iconSize - pad);
            }
        }
    }
}
