namespace RestaurantOtomasyon
{
    partial class SatisRaporlariForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatislar;
        
        // Paneller
        private System.Windows.Forms.Panel pnlKategoriler;
        private System.Windows.Forms.Panel pnlGrafik;

        // Kategori Butonları
        private System.Windows.Forms.Button btnCatAnayemek;
        private System.Windows.Forms.Button btnCatIcecekler;
        private System.Windows.Forms.Button btnCatTatlilar;
        private System.Windows.Forms.Button btnCatSalata;
        private System.Windows.Forms.Button btnCatFastfood;
        private System.Windows.Forms.Button btnCatCorba;
        private System.Windows.Forms.Button btnCatMakarna;
        private System.Windows.Forms.Button btnCatArasicak;
        private System.Windows.Forms.Button btnCatTumUrunler;
        
        // Özet Etiketleri
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblNetProfit;

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
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            chartSatislar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlKategoriler = new Panel();
            pnlGrafik = new Panel();
            btnCatAnayemek = new Button();
            btnCatIcecekler = new Button();
            btnCatTatlilar = new Button();
            btnCatSalata = new Button();
            btnCatFastfood = new Button();
            btnCatCorba = new Button();
            btnCatMakarna = new Button();
            btnCatArasicak = new Button();
            btnCatTumUrunler = new Button();
            pnlOzet = new Panel();
            lblTotalRevenue = new Label();
            lblCash = new Label();
            lblCard = new Label();
            lblExpenses = new Label();
            lblNetProfit = new Label();
            ((System.ComponentModel.ISupportInitialize)(chartSatislar)).BeginInit();
            pnlKategoriler.SuspendLayout();
            pnlGrafik.SuspendLayout();
            pnlOzet.SuspendLayout();
            SuspendLayout();
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(-500, -500);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(200, 27);
            dtpBaslangic.TabIndex = 100;
            dtpBaslangic.Visible = false;
            dtpBaslangic.ValueChanged += dtpTarih_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(-500, -500);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(200, 27);
            dtpBitis.TabIndex = 101;
            dtpBitis.Visible = false;
            dtpBitis.ValueChanged += dtpTarih_ValueChanged;
            // 
            // pnlKategoriler
            // 
            pnlKategoriler.BackColor = Color.FromArgb(43, 43, 43);
            pnlKategoriler.BorderStyle = BorderStyle.FixedSingle;
            pnlKategoriler.Controls.Add(btnCatAnayemek);
            pnlKategoriler.Controls.Add(btnCatIcecekler);
            pnlKategoriler.Controls.Add(btnCatTatlilar);
            pnlKategoriler.Controls.Add(btnCatSalata);
            pnlKategoriler.Controls.Add(btnCatFastfood);
            pnlKategoriler.Controls.Add(btnCatCorba);
            pnlKategoriler.Controls.Add(btnCatMakarna);
            pnlKategoriler.Controls.Add(btnCatArasicak);
            pnlKategoriler.Controls.Add(btnCatTumUrunler);
            pnlKategoriler.Location = new Point(14, 14);
            pnlKategoriler.Name = "pnlKategoriler";
            pnlKategoriler.Size = new Size(300, 472);
            pnlKategoriler.TabIndex = 0;
            // 
            // pnlGrafik
            // 
            pnlGrafik.BackColor = Color.FromArgb(43, 43, 43);
            pnlGrafik.BorderStyle = BorderStyle.FixedSingle;
            pnlGrafik.Controls.Add(chartSatislar);
            pnlGrafik.Location = new Point(324, 130);
            pnlGrafik.Name = "pnlGrafik";
            pnlGrafik.Size = new Size(810, 356);
            pnlGrafik.TabIndex = 1;
            // 
            // pnlOzet
            // 
            pnlOzet.BackColor = Color.FromArgb(30, 30, 30);
            pnlOzet.BorderStyle = BorderStyle.FixedSingle;
            pnlOzet.Controls.Add(lblTotalRevenue);
            pnlOzet.Controls.Add(lblCash);
            pnlOzet.Controls.Add(lblCard);
            pnlOzet.Controls.Add(lblExpenses);
            pnlOzet.Controls.Add(lblNetProfit);
            pnlOzet.Location = new Point(324, 14);
            pnlOzet.Name = "pnlOzet";
            pnlOzet.Size = new Size(810, 100);
            pnlOzet.TabIndex = 2;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.White;
            lblTotalRevenue.Location = new Point(20, 15);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(160, 28);
            lblTotalRevenue.Text = "Toplam: 0,00 TL";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Font = new Font("Algerian", 10F, FontStyle.Italic);
            lblCash.ForeColor = Color.FromArgb(200, 200, 200);
            lblCash.Location = new Point(20, 55);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(120, 23);
            lblCash.Text = "Nakit: 0,00 TL";
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Font = new Font("Algerian", 10F, FontStyle.Italic);
            lblCard.ForeColor = Color.FromArgb(200, 200, 200);
            lblCard.Location = new Point(200, 55);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(120, 23);
            lblCard.Text = "Kart: 0,00 TL";
            // 
            // lblExpenses
            // 
            lblExpenses.AutoSize = true;
            lblExpenses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblExpenses.ForeColor = Color.FromArgb(255, 50, 50);
            lblExpenses.Location = new Point(400, 15);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(160, 28);
            lblExpenses.Text = "Gider: 0,00 TL";
            // 
            // lblNetProfit
            // 
            lblNetProfit.AutoSize = true;
            lblNetProfit.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblNetProfit.ForeColor = Color.LimeGreen;
            lblNetProfit.Location = new Point(580, 30);
            lblNetProfit.Name = "lblNetProfit";
            lblNetProfit.Size = new Size(180, 32);
            lblNetProfit.Text = "NET: 0,00 TL";
            // 
            // btnCatAnayemek
            // 
            btnCatTumUrunler.BackColor = Color.FromArgb(220, 0, 0);
            btnCatTumUrunler.FlatAppearance.BorderSize = 0;
            btnCatTumUrunler.FlatStyle = FlatStyle.Flat;
            btnCatTumUrunler.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCatTumUrunler.ForeColor = Color.White;
            btnCatTumUrunler.Location = new Point(5, 385);
            btnCatTumUrunler.Name = "btnCatTumUrunler";
            btnCatTumUrunler.Size = new Size(285, 75);
            btnCatTumUrunler.TabIndex = 8;
            btnCatTumUrunler.Tag = "TÜM ÜRÜNLER";
            btnCatTumUrunler.Text = "🌟 TÜM ÜRÜNLER";
            btnCatTumUrunler.UseVisualStyleBackColor = false;
            btnCatTumUrunler.Click += KategoriButon_Click;
            // 
            // chartSatislar
            // 
            chartSatislar.Dock = DockStyle.Fill;
            chartSatislar.Name = "chartSatislar";
            chartSatislar.TabIndex = 0;
            // 
            // SatisRaporlariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(1150, 500);
            Controls.Add(pnlOzet);
            Controls.Add(pnlGrafik);
            Controls.Add(pnlKategoriler);
            Controls.Add(dtpBaslangic);
            Controls.Add(dtpBitis);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SatisRaporlariForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Raporları Grafiği";
            Load += SatisRaporlariForm_Load;
            ((System.ComponentModel.ISupportInitialize)(chartSatislar)).EndInit();
            pnlKategoriler.ResumeLayout(false);
            pnlGrafik.ResumeLayout(false);
            pnlOzet.ResumeLayout(false);
            pnlOzet.PerformLayout();
            ResumeLayout(false);
        }
    }
}

