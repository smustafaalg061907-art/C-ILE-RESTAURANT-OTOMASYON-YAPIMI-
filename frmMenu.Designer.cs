namespace RestaurantOtomasyon
{
    partial class frmMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        
        // Tiles
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnPaketServis;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;

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
            lblUser = new Label();
            pnlDashboard = new Panel();
            btnMasa = new Button();
            btnRezervasyon = new Button();
            btnPaketServis = new Button();
            btnMusteriler = new Button();
            btnKasa = new Button();
            btnMutfak = new Button();
            btnRaporlar = new Button();
            btnAyarlar = new Button();
            btnCikis = new Button();
            pnlControlBox = new Panel();
            btnMin = new Button();
            btnClose = new Button();
            pnlDashboard.SuspendLayout();
            pnlControlBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Black;
            lblUser.Font = new Font("Algerian", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.Control;
            lblUser.Location = new Point(57, 27);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(302, 41);
            lblUser.TabIndex = 2;
            lblUser.Text = "Kullanıcı: User";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(btnMasa);
            pnlDashboard.Controls.Add(btnRezervasyon);
            pnlDashboard.Controls.Add(btnPaketServis);
            pnlDashboard.Controls.Add(btnMusteriler);
            pnlDashboard.Controls.Add(btnKasa);
            pnlDashboard.Controls.Add(btnMutfak);
            pnlDashboard.Controls.Add(btnRaporlar);
            pnlDashboard.Controls.Add(btnAyarlar);
            pnlDashboard.Controls.Add(btnCikis);
            pnlDashboard.Location = new Point(57, 80);
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(583, 507);
            pnlDashboard.TabIndex = 1;
            // 
            // btnMasa
            // 
            btnMasa.BackColor = Color.Black;
            btnMasa.FlatAppearance.BorderSize = 0;
            btnMasa.FlatStyle = FlatStyle.Flat;
            btnMasa.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnMasa.ForeColor = Color.White;
            btnMasa.Location = new Point(0, 0);
            btnMasa.Margin = new Padding(3, 4, 3, 4);
            btnMasa.Name = "btnMasa";
            btnMasa.Size = new Size(286, 160);
            btnMasa.TabIndex = 0;
            btnMasa.Text = "MASA";
            btnMasa.UseVisualStyleBackColor = false;
            btnMasa.Click += btnMasa_Click;
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.BackColor = Color.Black;
            btnRezervasyon.FlatAppearance.BorderSize = 0;
            btnRezervasyon.FlatStyle = FlatStyle.Flat;
            btnRezervasyon.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRezervasyon.ForeColor = Color.White;
            btnRezervasyon.Location = new Point(297, 0);
            btnRezervasyon.Margin = new Padding(3, 4, 3, 4);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(137, 160);
            btnRezervasyon.TabIndex = 1;
            btnRezervasyon.Text = "Rezerv.";
            btnRezervasyon.UseVisualStyleBackColor = false;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // btnPaketServis
            // 
            btnPaketServis.BackColor = Color.Black;
            btnPaketServis.FlatAppearance.BorderSize = 0;
            btnPaketServis.FlatStyle = FlatStyle.Flat;
            btnPaketServis.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnPaketServis.ForeColor = Color.White;
            btnPaketServis.Location = new Point(446, 0);
            btnPaketServis.Margin = new Padding(3, 4, 3, 4);
            btnPaketServis.Name = "btnPaketServis";
            btnPaketServis.Size = new Size(137, 160);
            btnPaketServis.TabIndex = 2;
            btnPaketServis.Text = "Paket";
            btnPaketServis.UseVisualStyleBackColor = false;
            btnPaketServis.Click += btnPaketServis_Click;
            // 
            // btnMusteriler
            // 
            btnMusteriler.BackColor = Color.Black;
            btnMusteriler.FlatAppearance.BorderSize = 0;
            btnMusteriler.FlatStyle = FlatStyle.Flat;
            btnMusteriler.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnMusteriler.ForeColor = Color.White;
            btnMusteriler.Location = new Point(0, 173);
            btnMusteriler.Margin = new Padding(3, 4, 3, 4);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(137, 160);
            btnMusteriler.TabIndex = 3;
            btnMusteriler.Text = "Müşteri";
            btnMusteriler.UseVisualStyleBackColor = false;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // btnKasa
            // 
            btnKasa.BackColor = Color.Black;
            btnKasa.FlatAppearance.BorderSize = 0;
            btnKasa.FlatStyle = FlatStyle.Flat;
            btnKasa.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnKasa.ForeColor = Color.White;
            btnKasa.Location = new Point(149, 173);
            btnKasa.Margin = new Padding(3, 4, 3, 4);
            btnKasa.Name = "btnKasa";
            btnKasa.Size = new Size(137, 160);
            btnKasa.TabIndex = 4;
            btnKasa.Text = "Kasa";
            btnKasa.UseVisualStyleBackColor = false;
            btnKasa.Click += btnKasa_Click;
            // 
            // btnMutfak
            // 
            btnMutfak.BackColor = Color.Black;
            btnMutfak.FlatAppearance.BorderSize = 0;
            btnMutfak.FlatStyle = FlatStyle.Flat;
            btnMutfak.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnMutfak.ForeColor = Color.White;
            btnMutfak.Location = new Point(297, 173);
            btnMutfak.Margin = new Padding(3, 4, 3, 4);
            btnMutfak.Name = "btnMutfak";
            btnMutfak.Size = new Size(286, 160);
            btnMutfak.TabIndex = 5;
            btnMutfak.Text = "MUTFAK";
            btnMutfak.UseVisualStyleBackColor = false;
            btnMutfak.Click += btnMutfak_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Black;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.Location = new Point(0, 347);
            btnRaporlar.Margin = new Padding(3, 4, 3, 4);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(137, 160);
            btnRaporlar.TabIndex = 6;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.Black;
            btnAyarlar.FlatAppearance.BorderSize = 0;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Location = new Point(149, 347);
            btnAyarlar.Margin = new Padding(3, 4, 3, 4);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(137, 160);
            btnAyarlar.TabIndex = 7;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(238, 17, 17);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(297, 347);
            btnCikis.Margin = new Padding(3, 4, 3, 4);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(286, 160);
            btnCikis.TabIndex = 9;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // pnlControlBox
            // 
            pnlControlBox.Controls.Add(btnMin);
            pnlControlBox.Controls.Add(btnClose);
            pnlControlBox.Location = new Point(660, 10);
            pnlControlBox.Name = "pnlControlBox";
            pnlControlBox.Size = new Size(100, 40);
            pnlControlBox.TabIndex = 3;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.FromArgb(50, 50, 50);
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(5, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 30);
            btnMin.TabIndex = 0;
            btnMin.Text = "_";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(200, 0, 0);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(50, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(798, 640);
            Controls.Add(pnlControlBox);
            Controls.Add(pnlDashboard);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            Load += DashboardForm_Load;
            Resize += frmMenu_Resize;
            pnlDashboard.ResumeLayout(false);
            pnlControlBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

