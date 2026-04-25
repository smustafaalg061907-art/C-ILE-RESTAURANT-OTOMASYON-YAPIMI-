namespace RestaurantOtomasyon
{
    partial class frmRezervarsyon
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTarih = new Label();
            lblMasaSec = new Label();
            lblKisiSayisi = new Label();
            lblAciklama = new Label();
            lblMusteri = new Label();
            lblTelefon = new Label();
            lblAdres = new Label();
            dtpTarih = new DateTimePicker();
            cmbMasaSec = new ComboBox();
            cmbKisiSayisi = new ComboBox();
            txtAciklama = new TextBox();
            txtMusteri = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            dgvMusteriler = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colSoyad = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colAdres = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            btnYeniMusteri = new Button();
            btnRezervasyonAc = new Button();
            btnRezervasyonlar = new Button();
            btnMusteriGuncelle = new Button();
            btnGeriDonBuyuk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Algerian", 12F, FontStyle.Italic);
            lblTarih.ForeColor = Color.White;
            lblTarih.Location = new Point(38, 47);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(62, 28);
            lblTarih.TabIndex = 21;
            lblTarih.Text = "Tarih :";
            // 
            // lblMasaSec
            // 
            lblMasaSec.AutoSize = true;
            lblMasaSec.Font = new Font("Algerian", 12F, FontStyle.Italic);
            lblMasaSec.ForeColor = Color.White;
            lblMasaSec.Location = new Point(8, 92);
            lblMasaSec.Name = "lblMasaSec";
            lblMasaSec.Size = new Size(102, 28);
            lblMasaSec.TabIndex = 19;
            lblMasaSec.Text = "Masa Seç :";
            // 
            // lblKisiSayisi
            // 
            lblKisiSayisi.AutoSize = true;
            lblKisiSayisi.Font = new Font("Algerian", 12F, FontStyle.Italic);
            lblKisiSayisi.ForeColor = Color.White;
            lblKisiSayisi.Location = new Point(8, 137);
            lblKisiSayisi.Name = "lblKisiSayisi";
            lblKisiSayisi.Size = new Size(105, 28);
            lblKisiSayisi.TabIndex = 17;
            lblKisiSayisi.Text = "Kişi Sayısı :";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Algerian", 12F, FontStyle.Italic);
            lblAciklama.ForeColor = Color.White;
            lblAciklama.Location = new Point(8, 182);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(100, 28);
            lblAciklama.TabIndex = 15;
            lblAciklama.Text = "Açıklama :";
            // 
            // lblMusteri
            // 
            lblMusteri.AutoSize = true;
            lblMusteri.Font = new Font("Algerian", 14F, FontStyle.Italic);
            lblMusteri.ForeColor = Color.White;
            lblMusteri.Location = new Point(398, 7);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.Size = new Size(110, 32);
            lblMusteri.TabIndex = 13;
            lblMusteri.Text = "MÜŞTERİ";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Algerian", 14F, FontStyle.Italic);
            lblTelefon.ForeColor = Color.White;
            lblTelefon.Location = new Point(618, 7);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(110, 32);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "TELEFON";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Algerian", 14F, FontStyle.Italic);
            lblAdres.ForeColor = Color.White;
            lblAdres.Location = new Point(838, 7);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(85, 32);
            lblAdres.TabIndex = 9;
            lblAdres.Text = "ADRES";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Algerian", 12F, FontStyle.Italic);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(128, 45);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 34);
            dtpTarih.TabIndex = 20;
            // 
            // cmbMasaSec
            // 
            cmbMasaSec.Font = new Font("Algerian", 12F, FontStyle.Italic);
            cmbMasaSec.FormattingEnabled = true;
            cmbMasaSec.Location = new Point(128, 89);
            cmbMasaSec.Name = "cmbMasaSec";
            cmbMasaSec.Size = new Size(200, 36);
            cmbMasaSec.TabIndex = 18;
            // 
            // cmbKisiSayisi
            // 
            cmbKisiSayisi.Font = new Font("Algerian", 12F, FontStyle.Italic);
            cmbKisiSayisi.FormattingEnabled = true;
            cmbKisiSayisi.Location = new Point(128, 134);
            cmbKisiSayisi.Name = "cmbKisiSayisi";
            cmbKisiSayisi.Size = new Size(200, 36);
            cmbKisiSayisi.TabIndex = 16;
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Algerian", 12F, FontStyle.Italic);
            txtAciklama.Location = new Point(128, 179);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(200, 200);
            txtAciklama.TabIndex = 14;
            // 
            // txtMusteri
            // 
            txtMusteri.Font = new Font("Algerian", 14F, FontStyle.Italic);
            txtMusteri.Location = new Point(398, 45);
            txtMusteri.Name = "txtMusteri";
            txtMusteri.Size = new Size(200, 39);
            txtMusteri.TabIndex = 12;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Algerian", 14F, FontStyle.Italic);
            txtTelefon.Location = new Point(618, 45);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 39);
            txtTelefon.TabIndex = 10;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Algerian", 14F, FontStyle.Italic);
            txtAdres.Location = new Point(838, 45);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(260, 39);
            txtAdres.TabIndex = 8;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AllowUserToAddRows = false;
            dgvMusteriler.AllowUserToDeleteRows = false;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMusteriler.ColumnHeadersHeight = 40;
            dgvMusteriler.Columns.AddRange(new DataGridViewColumn[] { colAd, colSoyad, colTelefon, colAdres, colEmail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Algerian", 11F, FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMusteriler.Location = new Point(398, 97);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.ReadOnly = true;
            dgvMusteriler.RowHeadersVisible = false;
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.RowTemplate.Height = 35;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.Size = new Size(700, 320);
            dgvMusteriler.TabIndex = 7;
            dgvMusteriler.SelectionChanged += dgvMusteriler_SelectionChanged;
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.ReadOnly = true;
            // 
            // colSoyad
            // 
            colSoyad.HeaderText = "Soyad";
            colSoyad.MinimumWidth = 6;
            colSoyad.Name = "colSoyad";
            colSoyad.ReadOnly = true;
            // 
            // colTelefon
            // 
            colTelefon.HeaderText = "Telefon";
            colTelefon.MinimumWidth = 6;
            colTelefon.Name = "colTelefon";
            colTelefon.ReadOnly = true;
            // 
            // colAdres
            // 
            colAdres.HeaderText = "Adres";
            colAdres.MinimumWidth = 6;
            colAdres.Name = "colAdres";
            colAdres.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackColor = Color.FromArgb(128, 255, 128);
            btnYeniMusteri.FlatAppearance.BorderSize = 0;
            btnYeniMusteri.FlatStyle = FlatStyle.Flat;
            btnYeniMusteri.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnYeniMusteri.ForeColor = Color.White;
            btnYeniMusteri.Location = new Point(20, 440);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(260, 110);
            btnYeniMusteri.TabIndex = 6;
            btnYeniMusteri.Text = "👤   YENİ\r\n     MÜŞTERİ";
            btnYeniMusteri.UseVisualStyleBackColor = false;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnRezervasyonAc
            // 
            btnRezervasyonAc.BackColor = Color.FromArgb(255, 80, 0);
            btnRezervasyonAc.FlatAppearance.BorderSize = 0;
            btnRezervasyonAc.FlatStyle = FlatStyle.Flat;
            btnRezervasyonAc.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnRezervasyonAc.ForeColor = Color.White;
            btnRezervasyonAc.Location = new Point(290, 440);
            btnRezervasyonAc.Name = "btnRezervasyonAc";
            btnRezervasyonAc.Size = new Size(260, 110);
            btnRezervasyonAc.TabIndex = 5;
            btnRezervasyonAc.Text = "📅   REZERVASYONU\r\n           AÇ";
            btnRezervasyonAc.UseVisualStyleBackColor = false;
            btnRezervasyonAc.Click += btnRezervasyonAc_Click;
            // 
            // btnRezervasyonlar
            // 
            btnRezervasyonlar.BackColor = Color.FromArgb(255, 128, 128);
            btnRezervasyonlar.FlatAppearance.BorderSize = 0;
            btnRezervasyonlar.FlatStyle = FlatStyle.Flat;
            btnRezervasyonlar.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnRezervasyonlar.ForeColor = Color.White;
            btnRezervasyonlar.Location = new Point(560, 440);
            btnRezervasyonlar.Name = "btnRezervasyonlar";
            btnRezervasyonlar.Size = new Size(260, 110);
            btnRezervasyonlar.TabIndex = 4;
            btnRezervasyonlar.Text = "✅   REZERVASYONLAR";
            btnRezervasyonlar.UseVisualStyleBackColor = false;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackColor = Color.FromArgb(192, 192, 0);
            btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            btnMusteriGuncelle.FlatStyle = FlatStyle.Flat;
            btnMusteriGuncelle.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnMusteriGuncelle.ForeColor = Color.White;
            btnMusteriGuncelle.Location = new Point(830, 440);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(260, 110);
            btnMusteriGuncelle.TabIndex = 3;
            btnMusteriGuncelle.Text = "🔄   MÜŞTERİ\r\n         GÜNCELLE";
            btnMusteriGuncelle.UseVisualStyleBackColor = false;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnGeriDonBuyuk
            // 
            btnGeriDonBuyuk.BackColor = Color.White;
            btnGeriDonBuyuk.FlatAppearance.BorderSize = 0;
            btnGeriDonBuyuk.FlatStyle = FlatStyle.Flat;
            btnGeriDonBuyuk.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnGeriDonBuyuk.ForeColor = Color.Black;
            btnGeriDonBuyuk.Location = new Point(1100, 440);
            btnGeriDonBuyuk.Name = "btnGeriDonBuyuk";
            btnGeriDonBuyuk.Size = new Size(120, 110);
            btnGeriDonBuyuk.TabIndex = 2;
            btnGeriDonBuyuk.Text = "↩️\r\nGERİ DÖN";
            btnGeriDonBuyuk.UseVisualStyleBackColor = false;
            btnGeriDonBuyuk.Click += btnGeriDon_Click;
            // 
            // frmRezervarsyon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(1250, 650);
            Controls.Add(btnGeriDonBuyuk);
            Controls.Add(btnMusteriGuncelle);
            Controls.Add(btnRezervasyonlar);
            Controls.Add(btnRezervasyonAc);
            Controls.Add(btnYeniMusteri);
            Controls.Add(dgvMusteriler);
            Controls.Add(txtAdres);
            Controls.Add(lblAdres);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtMusteri);
            Controls.Add(lblMusteri);
            Controls.Add(txtAciklama);
            Controls.Add(lblAciklama);
            Controls.Add(cmbKisiSayisi);
            Controls.Add(lblKisiSayisi);
            Controls.Add(cmbMasaSec);
            Controls.Add(lblMasaSec);
            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRezervarsyon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervasyonlar";
            Load += RezervasyonlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblMasaSec;
        private System.Windows.Forms.ComboBox cmbMasaSec;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.ComboBox cmbKisiSayisi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnRezervasyonAc;
        private System.Windows.Forms.Button btnRezervasyonlar;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnGeriDonBuyuk;
    }
}

