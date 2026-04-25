namespace RestaurantOtomasyon
{
    partial class frmLock
    {
        private System.ComponentModel.IContainer components = null;

        // Top bar
        private System.Windows.Forms.Label lblSiparisler;
        private System.Windows.Forms.Label lblSiparisCount;

        // Order items grid
        private System.Windows.Forms.DataGridView dgvOrderItems;

        // Özel İndirim GroupBox
        private System.Windows.Forms.GroupBox grpOzelIndirim;
        private System.Windows.Forms.CheckBox chkIndirimUygula;

        // Ödeme Bilgileri GroupBox
        private System.Windows.Forms.GroupBox grpOdemeBilgileri;
        private System.Windows.Forms.Label lblIndirimLabel;
        private System.Windows.Forms.Label lblIndirimValue;
        private System.Windows.Forms.Label lblIndirimTL;
        private System.Windows.Forms.Label lblKDVLabel;
        private System.Windows.Forms.Label lblKDVValue;
        private System.Windows.Forms.Label lblKDVTL;
        private System.Windows.Forms.Label lblFiyatLabel;
        private System.Windows.Forms.Label lblFiyatValue;
        private System.Windows.Forms.Label lblFiyatTL;
        private System.Windows.Forms.Label lblAraToplamLabel;
        private System.Windows.Forms.Label lblAraToplamValue;
        private System.Windows.Forms.Label lblAraToplamTL;

        // Özel Aktivite
        private System.Windows.Forms.GroupBox grpOzelAktivite;
        private System.Windows.Forms.Label lblIndirimTutari;
        private System.Windows.Forms.TextBox txtIndirimTutari;

        // Ödeme Türü GroupBox
        private System.Windows.Forms.GroupBox grpOdemeTuru;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbTicket;

        // Right side buttons
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Button btnHesapKapat;

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
            lblSiparisler = new Label();
            lblSiparisCount = new Label();
            dgvOrderItems = new DataGridView();
            grpOzelIndirim = new GroupBox();
            chkIndirimUygula = new CheckBox();
            grpOzelAktivite = new GroupBox();
            lblIndirimTutari = new Label();
            txtIndirimTutari = new TextBox();
            grpOdemeBilgileri = new GroupBox();
            lblIndirimLabel = new Label();
            lblIndirimValue = new Label();
            lblIndirimTL = new Label();
            lblKDVLabel = new Label();
            lblKDVValue = new Label();
            lblKDVTL = new Label();
            lblFiyatLabel = new Label();
            lblFiyatValue = new Label();
            lblFiyatTL = new Label();
            lblAraToplamLabel = new Label();
            lblAraToplamValue = new Label();
            lblAraToplamTL = new Label();
            grpOdemeTuru = new GroupBox();
            rbNakit = new RadioButton();
            rbKrediKarti = new RadioButton();
            rbTicket = new RadioButton();
            btnHesapOzeti = new Button();
            btnHesapKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            grpOzelIndirim.SuspendLayout();
            grpOzelAktivite.SuspendLayout();
            grpOdemeBilgileri.SuspendLayout();
            grpOdemeTuru.SuspendLayout();
            SuspendLayout();
            // 
            // lblSiparisler
            // 
            lblSiparisler.AutoSize = true;
            lblSiparisler.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            lblSiparisler.ForeColor = Color.White;
            lblSiparisler.Location = new Point(17, 13);
            lblSiparisler.Name = "lblSiparisler";
            lblSiparisler.Size = new Size(100, 28);
            lblSiparisler.TabIndex = 0;
            lblSiparisler.Text = "Siparişler";
            // 
            // lblSiparisCount
            // 
            lblSiparisCount.AutoSize = true;
            lblSiparisCount.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            lblSiparisCount.ForeColor = Color.FromArgb(255, 80, 80);
            lblSiparisCount.Location = new Point(126, 13);
            lblSiparisCount.Name = "lblSiparisCount";
            lblSiparisCount.Size = new Size(24, 28);
            lblSiparisCount.TabIndex = 1;
            lblSiparisCount.Text = "0";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.BackgroundColor = Color.White;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Algerian", 9F, FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrderItems.Location = new Point(17, 47);
            dgvOrderItems.Margin = new Padding(3, 4, 3, 4);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new Size(549, 240);
            dgvOrderItems.TabIndex = 2;
            // 
            // grpOzelIndirim
            // 
            grpOzelIndirim.Controls.Add(chkIndirimUygula);
            grpOzelIndirim.Font = new Font("Algerian", 10F, FontStyle.Italic);
            grpOzelIndirim.ForeColor = Color.White;
            grpOzelIndirim.Location = new Point(583, 13);
            grpOzelIndirim.Margin = new Padding(3, 4, 3, 4);
            grpOzelIndirim.Name = "grpOzelIndirim";
            grpOzelIndirim.Padding = new Padding(3, 4, 3, 4);
            grpOzelIndirim.Size = new Size(194, 93);
            grpOzelIndirim.TabIndex = 3;
            grpOzelIndirim.TabStop = false;
            grpOzelIndirim.Text = "Özel İndirim";
            // 
            // chkIndirimUygula
            // 
            chkIndirimUygula.AutoSize = true;
            chkIndirimUygula.Font = new Font("Algerian", 11F, FontStyle.Italic);
            chkIndirimUygula.ForeColor = Color.White;
            chkIndirimUygula.Location = new Point(17, 40);
            chkIndirimUygula.Margin = new Padding(3, 4, 3, 4);
            chkIndirimUygula.Name = "chkIndirimUygula";
            chkIndirimUygula.Size = new Size(156, 29);
            chkIndirimUygula.TabIndex = 0;
            chkIndirimUygula.Text = "İndirim Uygula";
            chkIndirimUygula.CheckedChanged += chkIndirimUygula_CheckedChanged;
            // 
            // grpOzelAktivite
            // 
            grpOzelAktivite.Controls.Add(lblIndirimTutari);
            grpOzelAktivite.Controls.Add(txtIndirimTutari);
            grpOzelAktivite.Font = new Font("Algerian", 10F, FontStyle.Italic);
            grpOzelAktivite.ForeColor = Color.White;
            grpOzelAktivite.Location = new Point(802, 13);
            grpOzelAktivite.Margin = new Padding(3, 4, 3, 4);
            grpOzelAktivite.Name = "grpOzelAktivite";
            grpOzelAktivite.Padding = new Padding(3, 4, 3, 4);
            grpOzelAktivite.Size = new Size(194, 113);
            grpOzelAktivite.TabIndex = 4;
            grpOzelAktivite.TabStop = false;
            grpOzelAktivite.Text = "Özel Aktivite";
            // 
            // lblIndirimTutari
            // 
            lblIndirimTutari.AutoSize = true;
            lblIndirimTutari.Font = new Font("Algerian", 10F, FontStyle.Italic);
            lblIndirimTutari.ForeColor = Color.White;
            lblIndirimTutari.Location = new Point(11, 33);
            lblIndirimTutari.Name = "lblIndirimTutari";
            lblIndirimTutari.Size = new Size(166, 23);
            lblIndirimTutari.TabIndex = 0;
            lblIndirimTutari.Text = "İndirim Tutarı Giriniz";

            // 
            // txtIndirimTutari
            // 
            txtIndirimTutari.Font = new Font("Algerian", 11F, FontStyle.Italic);
            txtIndirimTutari.Location = new Point(11, 67);
            txtIndirimTutari.Margin = new Padding(3, 4, 3, 4);
            txtIndirimTutari.Name = "txtIndirimTutari";
            txtIndirimTutari.Size = new Size(171, 32);
            txtIndirimTutari.TabIndex = 0;
            // 
            // grpOdemeBilgileri
            // 
            grpOdemeBilgileri.Controls.Add(lblIndirimLabel);
            grpOdemeBilgileri.Controls.Add(lblIndirimValue);
            grpOdemeBilgileri.Controls.Add(lblIndirimTL);
            grpOdemeBilgileri.Controls.Add(lblKDVLabel);
            grpOdemeBilgileri.Controls.Add(lblKDVValue);
            grpOdemeBilgileri.Controls.Add(lblKDVTL);
            grpOdemeBilgileri.Controls.Add(lblFiyatLabel);
            grpOdemeBilgileri.Controls.Add(lblFiyatValue);
            grpOdemeBilgileri.Controls.Add(lblFiyatTL);
            grpOdemeBilgileri.Controls.Add(lblAraToplamLabel);
            grpOdemeBilgileri.Controls.Add(lblAraToplamValue);
            grpOdemeBilgileri.Controls.Add(lblAraToplamTL);
            grpOdemeBilgileri.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            grpOdemeBilgileri.ForeColor = Color.White;
            grpOdemeBilgileri.Location = new Point(17, 300);
            grpOdemeBilgileri.Margin = new Padding(3, 4, 3, 4);
            grpOdemeBilgileri.Name = "grpOdemeBilgileri";
            grpOdemeBilgileri.Padding = new Padding(3, 4, 3, 4);
            grpOdemeBilgileri.Size = new Size(274, 213);
            grpOdemeBilgileri.TabIndex = 5;
            grpOdemeBilgileri.TabStop = false;
            grpOdemeBilgileri.Text = "Ödeme Bilgileri";
            // 
            // lblIndirimLabel
            // 
            lblIndirimLabel.AutoSize = true;
            lblIndirimLabel.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblIndirimLabel.ForeColor = Color.White;
            lblIndirimLabel.Location = new Point(11, 33);
            lblIndirimLabel.Name = "lblIndirimLabel";
            lblIndirimLabel.Size = new Size(77, 25);
            lblIndirimLabel.TabIndex = 0;
            lblIndirimLabel.Text = "İndirim";
            // 
            // lblIndirimValue
            // 
            lblIndirimValue.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblIndirimValue.ForeColor = Color.White;
            lblIndirimValue.Location = new Point(149, 33);
            lblIndirimValue.Name = "lblIndirimValue";
            lblIndirimValue.Size = new Size(69, 27);
            lblIndirimValue.TabIndex = 1;
            lblIndirimValue.Text = "0";
            lblIndirimValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIndirimTL
            // 
            lblIndirimTL.AutoSize = true;
            lblIndirimTL.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblIndirimTL.ForeColor = Color.White;
            lblIndirimTL.Location = new Point(223, 33);
            lblIndirimTL.Name = "lblIndirimTL";
            lblIndirimTL.Size = new Size(33, 25);
            lblIndirimTL.TabIndex = 2;
            lblIndirimTL.Text = "TL";
            // 
            // lblKDVLabel
            // 
            lblKDVLabel.AutoSize = true;
            lblKDVLabel.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblKDVLabel.ForeColor = Color.White;
            lblKDVLabel.Location = new Point(11, 73);
            lblKDVLabel.Name = "lblKDVLabel";
            lblKDVLabel.Size = new Size(51, 25);
            lblKDVLabel.TabIndex = 3;
            lblKDVLabel.Text = "KDV";
            // 
            // lblKDVValue
            // 
            lblKDVValue.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblKDVValue.ForeColor = Color.White;
            lblKDVValue.Location = new Point(149, 73);
            lblKDVValue.Name = "lblKDVValue";
            lblKDVValue.Size = new Size(69, 27);
            lblKDVValue.TabIndex = 4;
            lblKDVValue.Text = "0";
            lblKDVValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKDVTL
            // 
            lblKDVTL.AutoSize = true;
            lblKDVTL.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblKDVTL.ForeColor = Color.White;
            lblKDVTL.Location = new Point(223, 73);
            lblKDVTL.Name = "lblKDVTL";
            lblKDVTL.Size = new Size(33, 25);
            lblKDVTL.TabIndex = 5;
            lblKDVTL.Text = "TL";
            // 
            // lblFiyatLabel
            // 
            lblFiyatLabel.AutoSize = true;
            lblFiyatLabel.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblFiyatLabel.ForeColor = Color.White;
            lblFiyatLabel.Location = new Point(11, 113);
            lblFiyatLabel.Name = "lblFiyatLabel";
            lblFiyatLabel.Size = new Size(54, 25);
            lblFiyatLabel.TabIndex = 6;
            lblFiyatLabel.Text = "Fiyat";
            // 
            // lblFiyatValue
            // 
            lblFiyatValue.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblFiyatValue.ForeColor = Color.White;
            lblFiyatValue.Location = new Point(149, 113);
            lblFiyatValue.Name = "lblFiyatValue";
            lblFiyatValue.Size = new Size(69, 27);
            lblFiyatValue.TabIndex = 7;
            lblFiyatValue.Text = "0";
            lblFiyatValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFiyatTL
            // 
            lblFiyatTL.AutoSize = true;
            lblFiyatTL.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblFiyatTL.ForeColor = Color.White;
            lblFiyatTL.Location = new Point(223, 113);
            lblFiyatTL.Name = "lblFiyatTL";
            lblFiyatTL.Size = new Size(33, 25);
            lblFiyatTL.TabIndex = 8;
            lblFiyatTL.Text = "TL";
            // 
            // lblAraToplamLabel
            // 
            lblAraToplamLabel.AutoSize = true;
            lblAraToplamLabel.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblAraToplamLabel.ForeColor = Color.White;
            lblAraToplamLabel.Location = new Point(11, 160);
            lblAraToplamLabel.Name = "lblAraToplamLabel";
            lblAraToplamLabel.Size = new Size(113, 25);
            lblAraToplamLabel.TabIndex = 9;
            lblAraToplamLabel.Text = "Ara Toplam";
            // 
            // lblAraToplamValue
            // 
            lblAraToplamValue.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblAraToplamValue.ForeColor = Color.White;
            lblAraToplamValue.Location = new Point(149, 160);
            lblAraToplamValue.Name = "lblAraToplamValue";
            lblAraToplamValue.Size = new Size(69, 27);
            lblAraToplamValue.TabIndex = 10;
            lblAraToplamValue.Text = "0";
            lblAraToplamValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAraToplamTL
            // 
            lblAraToplamTL.AutoSize = true;
            lblAraToplamTL.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblAraToplamTL.ForeColor = Color.White;
            lblAraToplamTL.Location = new Point(223, 160);
            lblAraToplamTL.Name = "lblAraToplamTL";
            lblAraToplamTL.Size = new Size(33, 25);
            lblAraToplamTL.TabIndex = 11;
            lblAraToplamTL.Text = "TL";
            // 
            // grpOdemeTuru
            // 
            grpOdemeTuru.Controls.Add(rbNakit);
            grpOdemeTuru.Controls.Add(rbKrediKarti);
            grpOdemeTuru.Controls.Add(rbTicket);
            grpOdemeTuru.Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic);
            grpOdemeTuru.ForeColor = Color.White;
            grpOdemeTuru.Location = new Point(303, 300);
            grpOdemeTuru.Margin = new Padding(3, 4, 3, 4);
            grpOdemeTuru.Name = "grpOdemeTuru";
            grpOdemeTuru.Padding = new Padding(3, 4, 3, 4);
            grpOdemeTuru.Size = new Size(229, 213);
            grpOdemeTuru.TabIndex = 6;
            grpOdemeTuru.TabStop = false;
            grpOdemeTuru.Text = "Ödeme Türü";
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.Checked = true;
            rbNakit.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            rbNakit.ForeColor = Color.White;
            rbNakit.Location = new Point(23, 40);
            rbNakit.Margin = new Padding(3, 4, 3, 4);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new Size(85, 32);
            rbNakit.TabIndex = 0;
            rbNakit.TabStop = true;
            rbNakit.Text = "Nakit";
            // 
            // rbKrediKarti
            // 
            rbKrediKarti.AutoSize = true;
            rbKrediKarti.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            rbKrediKarti.ForeColor = Color.White;
            rbKrediKarti.Location = new Point(23, 93);
            rbKrediKarti.Margin = new Padding(3, 4, 3, 4);
            rbKrediKarti.Name = "rbKrediKarti";
            rbKrediKarti.Size = new Size(136, 32);
            rbKrediKarti.TabIndex = 1;
            rbKrediKarti.Text = "Kredi Kartı";
            // 
            // rbTicket
            // 
            rbTicket.AutoSize = true;
            rbTicket.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            rbTicket.ForeColor = Color.White;
            rbTicket.Location = new Point(23, 147);
            rbTicket.Margin = new Padding(3, 4, 3, 4);
            rbTicket.Name = "rbTicket";
            rbTicket.Size = new Size(91, 32);
            rbTicket.TabIndex = 2;
            rbTicket.Text = "Ticket";
            // 
            // btnHesapOzeti
            // 
            btnHesapOzeti.BackColor = Color.FromArgb(0, 150, 80);
            btnHesapOzeti.FlatAppearance.BorderSize = 0;
            btnHesapOzeti.FlatStyle = FlatStyle.Flat;
            btnHesapOzeti.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnHesapOzeti.ForeColor = Color.White;
            btnHesapOzeti.Location = new Point(583, 133);
            btnHesapOzeti.Margin = new Padding(3, 4, 3, 4);
            btnHesapOzeti.Name = "btnHesapOzeti";
            btnHesapOzeti.Size = new Size(194, 120);
            btnHesapOzeti.TabIndex = 7;
            btnHesapOzeti.Text = "🔍\nHESAP\nÖZETİ";
            btnHesapOzeti.UseVisualStyleBackColor = false;
            btnHesapOzeti.Click += btnHesapOzeti_Click;
            // 
            // btnHesapKapat
            // 
            btnHesapKapat.BackColor = Color.FromArgb(230, 50, 20);
            btnHesapKapat.FlatAppearance.BorderSize = 0;
            btnHesapKapat.FlatStyle = FlatStyle.Flat;
            btnHesapKapat.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnHesapKapat.ForeColor = Color.White;
            btnHesapKapat.Location = new Point(583, 267);
            btnHesapKapat.Margin = new Padding(3, 4, 3, 4);
            btnHesapKapat.Name = "btnHesapKapat";
            btnHesapKapat.Size = new Size(194, 120);
            btnHesapKapat.TabIndex = 8;
            btnHesapKapat.Text = "☑\nHESAP\nKAPAT";
            btnHesapKapat.UseVisualStyleBackColor = false;
            btnHesapKapat.Click += btnHesapKapat_Click;
            // 
            // frmLock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1056, 533);
            Controls.Add(lblSiparisler);
            Controls.Add(lblSiparisCount);
            Controls.Add(dgvOrderItems);
            Controls.Add(grpOzelIndirim);
            Controls.Add(grpOzelAktivite);
            Controls.Add(grpOdemeBilgileri);
            Controls.Add(grpOdemeTuru);
            Controls.Add(btnHesapOzeti);
            Controls.Add(btnHesapKapat);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            grpOzelIndirim.ResumeLayout(false);
            grpOzelIndirim.PerformLayout();
            grpOzelAktivite.ResumeLayout(false);
            grpOzelAktivite.PerformLayout();
            grpOdemeBilgileri.ResumeLayout(false);
            grpOdemeBilgileri.PerformLayout();
            grpOdemeTuru.ResumeLayout(false);
            grpOdemeTuru.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

