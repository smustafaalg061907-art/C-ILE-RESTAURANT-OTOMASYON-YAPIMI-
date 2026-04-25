namespace RestaurantOtomasyon
{
    partial class frmPaketSiparis
    {
        private System.ComponentModel.IContainer components = null;

        // Top bar
        private System.Windows.Forms.Label lblTableInfo;
        private System.Windows.Forms.Label lblUrunNo;
        private System.Windows.Forms.TextBox txtUrunNo;

        // Left menu category buttons
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnCatAnayemek;
        private System.Windows.Forms.Button btnCatIcecekler;
        private System.Windows.Forms.Button btnCatTatlilar;
        private System.Windows.Forms.Button btnCatSalata;
        private System.Windows.Forms.Button btnCatFastfood;
        private System.Windows.Forms.Button btnCatCorba;
        private System.Windows.Forms.Button btnCatArasicak;

        // Bottom left action buttons
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnGeri;

        // Center data grids
        private System.Windows.Forms.GroupBox grpMenuList;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.GroupBox grpSiparisler;
        private System.Windows.Forms.DataGridView dgvOrderItems;

        // Right numpad
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNumC;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnIptal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTableInfo = new Label();
            lblUrunNo = new Label();
            txtUrunNo = new TextBox();
            grpMenu = new GroupBox();
            btnCatAnayemek = new Button();
            btnCatIcecekler = new Button();
            btnCatTatlilar = new Button();
            btnCatSalata = new Button();
            btnCatFastfood = new Button();
            btnCatCorba = new Button();
            btnCatArasicak = new Button();
            btnOdeme = new Button();
            btnSiparis = new Button();
            btnGeri = new Button();
            grpMenuList = new GroupBox();
            dgvMenuItems = new DataGridView();
            grpSiparisler = new GroupBox();
            dgvOrderItems = new DataGridView();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNumC = new Button();
            btnNum0 = new Button();
            btnIptal = new Button();
            btnCatMakarna = new Button();
            grpMenu.SuspendLayout();
            grpMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
            grpSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // lblTableInfo
            // 
            lblTableInfo.AutoSize = true;
            lblTableInfo.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            lblTableInfo.ForeColor = Color.White;
            lblTableInfo.Location = new Point(17, 16);
            lblTableInfo.Name = "lblTableInfo";
            lblTableInfo.Size = new Size(105, 32);
            lblTableInfo.TabIndex = 0;
            lblTableInfo.Text = "MASA 1";
            // 
            // lblUrunNo
            // 
            lblUrunNo.AutoSize = true;
            lblUrunNo.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            lblUrunNo.ForeColor = Color.White;
            lblUrunNo.Location = new Point(206, 20);
            lblUrunNo.Name = "lblUrunNo";
            lblUrunNo.Size = new Size(92, 28);
            lblUrunNo.TabIndex = 1;
            lblUrunNo.Text = "Urun No";
            // 
            // txtUrunNo
            // 
            txtUrunNo.Font = new Font("Algerian", 12F, FontStyle.Italic);
            txtUrunNo.Location = new Point(303, 16);
            txtUrunNo.Margin = new Padding(3, 4, 3, 4);
            txtUrunNo.Name = "txtUrunNo";
            txtUrunNo.Size = new Size(114, 34);
            txtUrunNo.TabIndex = 0;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(btnCatAnayemek);
            grpMenu.Controls.Add(btnCatIcecekler);
            grpMenu.Controls.Add(btnCatTatlilar);
            grpMenu.Controls.Add(btnCatSalata);
            grpMenu.Controls.Add(btnCatFastfood);
            grpMenu.Controls.Add(btnCatCorba);
            grpMenu.Controls.Add(btnCatMakarna);
            grpMenu.Controls.Add(btnCatArasicak);
            grpMenu.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            grpMenu.ForeColor = Color.White;
            grpMenu.Location = new Point(17, 67);
            grpMenu.Margin = new Padding(3, 4, 3, 4);
            grpMenu.Name = "grpMenu";
            grpMenu.Padding = new Padding(3, 4, 3, 4);
            grpMenu.Size = new Size(314, 413);
            grpMenu.TabIndex = 2;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menü";
            // 
            // btnCatAnayemek
            // 
            btnCatAnayemek.BackColor = Color.Maroon;
            btnCatAnayemek.FlatAppearance.BorderSize = 0;
            btnCatAnayemek.FlatStyle = FlatStyle.Flat;
            btnCatAnayemek.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatAnayemek.ForeColor = Color.White;
            btnCatAnayemek.Location = new Point(7, 24);
            btnCatAnayemek.Margin = new Padding(3, 4, 3, 4);
            btnCatAnayemek.Name = "btnCatAnayemek";
            btnCatAnayemek.Size = new Size(149, 93);
            btnCatAnayemek.TabIndex = 0;
            btnCatAnayemek.Tag = "ANAYEMEK";
            btnCatAnayemek.Text = "ANAYEMEK";
            btnCatAnayemek.UseVisualStyleBackColor = false;
            btnCatAnayemek.Click += CategoryButton_Click;
            // 
            // btnCatIcecekler
            // 
            btnCatIcecekler.BackColor = Color.Maroon;
            btnCatIcecekler.FlatAppearance.BorderSize = 0;
            btnCatIcecekler.FlatStyle = FlatStyle.Flat;
            btnCatIcecekler.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatIcecekler.ForeColor = Color.White;
            btnCatIcecekler.Location = new Point(158, 24);
            btnCatIcecekler.Margin = new Padding(3, 4, 3, 4);
            btnCatIcecekler.Name = "btnCatIcecekler";
            btnCatIcecekler.Size = new Size(149, 93);
            btnCatIcecekler.TabIndex = 1;
            btnCatIcecekler.Tag = "İÇECEKLER";
            btnCatIcecekler.Text = "İÇECEKLER";
            btnCatIcecekler.UseVisualStyleBackColor = false;
            btnCatIcecekler.Click += CategoryButton_Click;
            // 
            // btnCatTatlilar
            // 
            btnCatTatlilar.BackColor = Color.Maroon;
            btnCatTatlilar.FlatAppearance.BorderSize = 0;
            btnCatTatlilar.FlatStyle = FlatStyle.Flat;
            btnCatTatlilar.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatTatlilar.ForeColor = Color.White;
            btnCatTatlilar.Location = new Point(7, 120);
            btnCatTatlilar.Margin = new Padding(3, 4, 3, 4);
            btnCatTatlilar.Name = "btnCatTatlilar";
            btnCatTatlilar.Size = new Size(149, 93);
            btnCatTatlilar.TabIndex = 2;
            btnCatTatlilar.Tag = "TATLILAR";
            btnCatTatlilar.Text = "TATLILAR";
            btnCatTatlilar.UseVisualStyleBackColor = false;
            btnCatTatlilar.Click += CategoryButton_Click;
            // 
            // btnCatSalata
            // 
            btnCatSalata.BackColor = Color.Maroon;
            btnCatSalata.FlatAppearance.BorderSize = 0;
            btnCatSalata.FlatStyle = FlatStyle.Flat;
            btnCatSalata.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatSalata.ForeColor = Color.White;
            btnCatSalata.Location = new Point(158, 120);
            btnCatSalata.Margin = new Padding(3, 4, 3, 4);
            btnCatSalata.Name = "btnCatSalata";
            btnCatSalata.Size = new Size(149, 93);
            btnCatSalata.TabIndex = 3;
            btnCatSalata.Tag = "SALATA";
            btnCatSalata.Text = "SALATA";
            btnCatSalata.UseVisualStyleBackColor = false;
            btnCatSalata.Click += CategoryButton_Click;
            // 
            // btnCatFastfood
            // 
            btnCatFastfood.BackColor = Color.Maroon;
            btnCatFastfood.FlatAppearance.BorderSize = 0;
            btnCatFastfood.FlatStyle = FlatStyle.Flat;
            btnCatFastfood.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatFastfood.ForeColor = Color.White;
            btnCatFastfood.Location = new Point(7, 216);
            btnCatFastfood.Margin = new Padding(3, 4, 3, 4);
            btnCatFastfood.Name = "btnCatFastfood";
            btnCatFastfood.Size = new Size(149, 93);
            btnCatFastfood.TabIndex = 4;
            btnCatFastfood.Tag = "FASTFOOD";
            btnCatFastfood.Text = "FASTFOOD";
            btnCatFastfood.UseVisualStyleBackColor = false;
            btnCatFastfood.Click += CategoryButton_Click;
            // 
            // btnCatCorba
            // 
            btnCatCorba.BackColor = Color.Maroon;
            btnCatCorba.FlatAppearance.BorderSize = 0;
            btnCatCorba.FlatStyle = FlatStyle.Flat;
            btnCatCorba.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatCorba.ForeColor = Color.White;
            btnCatCorba.Location = new Point(158, 216);
            btnCatCorba.Margin = new Padding(3, 4, 3, 4);
            btnCatCorba.Name = "btnCatCorba";
            btnCatCorba.Size = new Size(149, 93);
            btnCatCorba.TabIndex = 5;
            btnCatCorba.Tag = "ÇORBA";
            btnCatCorba.Text = "ÇORBA";
            btnCatCorba.UseVisualStyleBackColor = false;
            btnCatCorba.Click += CategoryButton_Click;
            // 
            // btnCatArasicak
            // 
            btnCatArasicak.BackColor = Color.Maroon;
            btnCatArasicak.FlatAppearance.BorderSize = 0;
            btnCatArasicak.FlatStyle = FlatStyle.Flat;
            btnCatArasicak.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatArasicak.ForeColor = Color.White;
            btnCatArasicak.Location = new Point(158, 312);
            btnCatArasicak.Margin = new Padding(3, 4, 3, 4);
            btnCatArasicak.Name = "btnCatArasicak";
            btnCatArasicak.Size = new Size(149, 93);
            btnCatArasicak.TabIndex = 7;
            btnCatArasicak.Tag = "ARASICAK";
            btnCatArasicak.Text = "ARASICAK";
            btnCatArasicak.UseVisualStyleBackColor = false;
            btnCatArasicak.Click += CategoryButton_Click;
            // 
            // btnOdeme
            // 
            btnOdeme.BackColor = Color.Cyan;
            btnOdeme.FlatAppearance.BorderSize = 0;
            btnOdeme.FlatStyle = FlatStyle.Flat;
            btnOdeme.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            btnOdeme.ForeColor = Color.White;
            btnOdeme.Location = new Point(17, 487);
            btnOdeme.Margin = new Padding(3, 4, 3, 4);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(154, 73);
            btnOdeme.TabIndex = 3;
            btnOdeme.Text = "    ÖDEME";
            btnOdeme.UseVisualStyleBackColor = false;
            btnOdeme.Click += btnOdeme_Click;
            btnOdeme.Paint += btnOdeme_Paint;
            // 
            // btnSiparis
            // 
            btnSiparis.BackColor = Color.Lime;
            btnSiparis.FlatAppearance.BorderSize = 0;
            btnSiparis.FlatStyle = FlatStyle.Flat;
            btnSiparis.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            btnSiparis.ForeColor = Color.White;
            btnSiparis.Location = new Point(177, 487);
            btnSiparis.Margin = new Padding(3, 4, 3, 4);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(154, 73);
            btnSiparis.TabIndex = 4;
            btnSiparis.Text = "    SİPARİŞ";
            btnSiparis.UseVisualStyleBackColor = false;
            btnSiparis.Click += btnSiparis_Click;
            btnSiparis.Paint += btnSiparis_Paint;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.DarkRed;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(937, 11);
            btnGeri.Margin = new Padding(3, 4, 3, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(46, 47);
            btnGeri.TabIndex = 5;
            btnGeri.Text = "X";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // grpMenuList
            // 
            grpMenuList.Controls.Add(dgvMenuItems);
            grpMenuList.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            grpMenuList.ForeColor = Color.White;
            grpMenuList.Location = new Point(343, 67);
            grpMenuList.Margin = new Padding(3, 4, 3, 4);
            grpMenuList.Name = "grpMenuList";
            grpMenuList.Padding = new Padding(3, 4, 3, 4);
            grpMenuList.Size = new Size(417, 247);
            grpMenuList.TabIndex = 6;
            grpMenuList.TabStop = false;
            grpMenuList.Text = "Menü";
            // 
            // dgvMenuItems
            // 
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AllowUserToDeleteRows = false;
            dgvMenuItems.BackgroundColor = Color.White;
            dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMenuItems.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMenuItems.Location = new Point(7, 24);
            dgvMenuItems.Margin = new Padding(3, 4, 3, 4);
            dgvMenuItems.Name = "dgvMenuItems";
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.RowHeadersWidth = 51;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.Size = new Size(403, 213);
            dgvMenuItems.TabIndex = 0;
            dgvMenuItems.CellDoubleClick += dgvMenuItems_CellDoubleClick;
            // 
            // grpSiparisler
            // 
            grpSiparisler.Controls.Add(dgvOrderItems);
            grpSiparisler.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            grpSiparisler.ForeColor = Color.White;
            grpSiparisler.Location = new Point(343, 320);
            grpSiparisler.Margin = new Padding(3, 4, 3, 4);
            grpSiparisler.Name = "grpSiparisler";
            grpSiparisler.Padding = new Padding(3, 4, 3, 4);
            grpSiparisler.Size = new Size(417, 240);
            grpSiparisler.TabIndex = 7;
            grpSiparisler.TabStop = false;
            grpSiparisler.Text = "Siparişler";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.BackgroundColor = Color.White;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderItems.Location = new Point(7, 24);
            dgvOrderItems.Margin = new Padding(3, 4, 3, 4);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new Size(403, 207);
            dgvOrderItems.TabIndex = 0;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.Black;
            btnNum1.Cursor = Cursors.Hand;
            btnNum1.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum1.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum1.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum1.Location = new Point(777, 78);
            btnNum1.Margin = new Padding(3, 4, 3, 4);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(69, 67);
            btnNum1.TabIndex = 8;
            btnNum1.Tag = "1";
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += NumPad_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = Color.Black;
            btnNum2.Cursor = Cursors.Hand;
            btnNum2.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum2.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum2.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum2.Location = new Point(849, 78);
            btnNum2.Margin = new Padding(3, 4, 3, 4);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(69, 67);
            btnNum2.TabIndex = 9;
            btnNum2.Tag = "2";
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += NumPad_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = Color.Black;
            btnNum3.Cursor = Cursors.Hand;
            btnNum3.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum3.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum3.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum3.Location = new Point(921, 78);
            btnNum3.Margin = new Padding(3, 4, 3, 4);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(69, 67);
            btnNum3.TabIndex = 10;
            btnNum3.Tag = "3";
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += NumPad_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.Black;
            btnNum4.Cursor = Cursors.Hand;
            btnNum4.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum4.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum4.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum4.Location = new Point(777, 148);
            btnNum4.Margin = new Padding(3, 4, 3, 4);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(69, 67);
            btnNum4.TabIndex = 11;
            btnNum4.Tag = "4";
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += NumPad_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.Black;
            btnNum5.Cursor = Cursors.Hand;
            btnNum5.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum5.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum5.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum5.Location = new Point(849, 148);
            btnNum5.Margin = new Padding(3, 4, 3, 4);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(69, 67);
            btnNum5.TabIndex = 12;
            btnNum5.Tag = "5";
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += NumPad_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.Black;
            btnNum6.Cursor = Cursors.Hand;
            btnNum6.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum6.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum6.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum6.Location = new Point(921, 148);
            btnNum6.Margin = new Padding(3, 4, 3, 4);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(69, 67);
            btnNum6.TabIndex = 13;
            btnNum6.Tag = "6";
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += NumPad_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.Black;
            btnNum7.Cursor = Cursors.Hand;
            btnNum7.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum7.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum7.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum7.Location = new Point(777, 219);
            btnNum7.Margin = new Padding(3, 4, 3, 4);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(69, 67);
            btnNum7.TabIndex = 14;
            btnNum7.Tag = "7";
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += NumPad_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.Black;
            btnNum8.Cursor = Cursors.Hand;
            btnNum8.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum8.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum8.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum8.Location = new Point(849, 219);
            btnNum8.Margin = new Padding(3, 4, 3, 4);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(69, 67);
            btnNum8.TabIndex = 15;
            btnNum8.Tag = "8";
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += NumPad_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.Black;
            btnNum9.Cursor = Cursors.Hand;
            btnNum9.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum9.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum9.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum9.Location = new Point(921, 219);
            btnNum9.Margin = new Padding(3, 4, 3, 4);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(69, 67);
            btnNum9.TabIndex = 16;
            btnNum9.Tag = "9";
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += NumPad_Click;
            // 
            // btnNumC
            // 
            btnNumC.BackColor = Color.Black;
            btnNumC.Cursor = Cursors.Hand;
            btnNumC.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNumC.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNumC.ForeColor = Color.FromArgb(224, 224, 224);
            btnNumC.Location = new Point(777, 290);
            btnNumC.Margin = new Padding(3, 4, 3, 4);
            btnNumC.Name = "btnNumC";
            btnNumC.Size = new Size(69, 67);
            btnNumC.TabIndex = 17;
            btnNumC.Tag = "C";
            btnNumC.Text = "C";
            btnNumC.UseVisualStyleBackColor = false;
            btnNumC.Click += NumPad_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.Black;
            btnNum0.Cursor = Cursors.Hand;
            btnNum0.FlatAppearance.BorderColor = Color.FromArgb(200, 180, 30);
            btnNum0.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnNum0.ForeColor = Color.FromArgb(224, 224, 224);
            btnNum0.Location = new Point(921, 290);
            btnNum0.Margin = new Padding(3, 4, 3, 4);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(69, 67);
            btnNum0.TabIndex = 18;
            btnNum0.Tag = "0";
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += NumPad_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(64, 64, 64);
            btnIptal.FlatAppearance.BorderSize = 0;
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(777, 360);
            btnIptal.Margin = new Padding(3, 4, 3, 4);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(213, 80);
            btnIptal.TabIndex = 19;
            btnIptal.Text = "     İPTAL";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            btnIptal.Paint += btnIptal_Paint;
            // 
            // btnCatMakarna
            // 
            btnCatMakarna.BackColor = Color.Maroon;
            btnCatMakarna.FlatAppearance.BorderSize = 0;
            btnCatMakarna.FlatStyle = FlatStyle.Flat;
            btnCatMakarna.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCatMakarna.ForeColor = Color.White;
            btnCatMakarna.Location = new Point(7, 312);
            btnCatMakarna.Margin = new Padding(3, 4, 3, 4);
            btnCatMakarna.Name = "btnCatMakarna";
            btnCatMakarna.Size = new Size(149, 93);
            btnCatMakarna.TabIndex = 6;
            btnCatMakarna.Tag = "MEZELER";
            btnCatMakarna.Text = "MEZELER";
            btnCatMakarna.UseVisualStyleBackColor = false;
            btnCatMakarna.Click += CategoryButton_Click;
            // 
            // frmPaketSiparis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1009, 583);
            Controls.Add(lblTableInfo);
            Controls.Add(lblUrunNo);
            Controls.Add(txtUrunNo);
            Controls.Add(grpMenu);
            Controls.Add(btnOdeme);
            Controls.Add(btnSiparis);
            Controls.Add(btnGeri);
            Controls.Add(grpMenuList);
            Controls.Add(grpSiparisler);
            Controls.Add(btnNum1);
            Controls.Add(btnNum2);
            Controls.Add(btnNum3);
            Controls.Add(btnNum4);
            Controls.Add(btnNum5);
            Controls.Add(btnNum6);
            Controls.Add(btnNum7);
            Controls.Add(btnNum8);
            Controls.Add(btnNum9);
            Controls.Add(btnNumC);
            Controls.Add(btnNum0);
            Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPaketSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sipariş Ekranı";
            Load += OrderForm_Load;
            grpMenu.ResumeLayout(false);
            grpMenuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
            grpSiparisler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCatMakarna;
    }
}

