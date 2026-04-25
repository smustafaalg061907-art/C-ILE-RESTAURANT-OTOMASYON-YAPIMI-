namespace RestaurantOtomasyon
{
    partial class frmMusteriAra
    {
        private System.ComponentModel.IContainer components = null;

        // Top search fields
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtAdisyonId;

        // Data grid
        private System.Windows.Forms.DataGridView dgvCustomers;

        // Right side display & buttons
        private System.Windows.Forms.TextBox txtDetailBox;
        private System.Windows.Forms.Button btnAdisyonBul;
        private System.Windows.Forms.Button btnYenile;

        // Bottom buttons
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnSiparisler;

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
            lblAdi = new Label();
            lblSoyadi = new Label();
            lblTelefon = new Label();
            lblAdres = new Label();
            lblEMail = new Label();
            lblAdisyonId = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEMail = new TextBox();
            txtAdisyonId = new TextBox();
            dgvCustomers = new DataGridView();
            btnAdisyonBul = new Button();
            btnYenile = new Button();
            btnYeniMusteri = new Button();
            btnMusteriSec = new Button();
            btnMusteriGuncelle = new Button();
            btnSiparisler = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblAdi.ForeColor = Color.White;
            lblAdi.Location = new Point(15, 11);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(45, 25);
            lblAdi.TabIndex = 0;
            lblAdi.Text = "ADI";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblSoyadi.ForeColor = Color.White;
            lblSoyadi.Location = new Point(164, 11);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(81, 25);
            lblSoyadi.TabIndex = 1;
            lblSoyadi.Text = "SOYADI";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblTelefon.ForeColor = Color.White;
            lblTelefon.Location = new Point(318, 11);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(92, 25);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "TELEFON";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblAdres.ForeColor = Color.White;
            lblAdres.Location = new Point(758, 11);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(72, 25);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "ADRES";
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblEMail.ForeColor = Color.White;
            lblEMail.Location = new Point(471, 11);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(77, 25);
            lblEMail.TabIndex = 4;
            lblEMail.Text = "E-MAIL";
            // 
            // lblAdisyonId
            // 
            lblAdisyonId.AutoSize = true;
            lblAdisyonId.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblAdisyonId.ForeColor = Color.White;
            lblAdisyonId.Location = new Point(624, 11);
            lblAdisyonId.Name = "lblAdisyonId";
            lblAdisyonId.Size = new Size(122, 25);
            lblAdisyonId.TabIndex = 5;
            lblAdisyonId.Text = "ADİSYON ID";
            // 
            // txtAdi
            // 
            txtAdi.Font = new Font("Algerian", 10F, FontStyle.Italic);
            txtAdi.Location = new Point(15, 45);
            txtAdi.Margin = new Padding(3, 4, 3, 4);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(137, 30);
            txtAdi.TabIndex = 6;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Font = new Font("Algerian", 10F, FontStyle.Italic);
            txtSoyadi.Location = new Point(164, 45);
            txtSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(137, 30);
            txtSoyadi.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Algerian", 10F, FontStyle.Italic);
            txtTelefon.Location = new Point(318, 45);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(137, 30);
            txtTelefon.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Algerian", 10F, FontStyle.Italic);
            txtAdres.Location = new Point(758, 45);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(151, 30);
            txtAdres.TabIndex = 9;
            // 
            // txtEMail
            // 
            txtEMail.Font = new Font("Algerian", 10F, FontStyle.Italic);
            txtEMail.Location = new Point(471, 45);
            txtEMail.Margin = new Padding(3, 4, 3, 4);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(137, 30);
            txtEMail.TabIndex = 10;
            // 
            // txtAdisyonId
            // 
            txtAdisyonId.Font = new Font("Algerian", 10F, FontStyle.Italic);
            txtAdisyonId.Location = new Point(624, 45);
            txtAdisyonId.Margin = new Padding(3, 4, 3, 4);
            txtAdisyonId.Name = "txtAdisyonId";
            txtAdisyonId.Size = new Size(122, 30);
            txtAdisyonId.TabIndex = 11;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Algerian", 9F, FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.Location = new Point(15, 91);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(731, 327);
            dgvCustomers.TabIndex = 12;
            // 
            // btnAdisyonBul
            // 
            btnAdisyonBul.BackColor = Color.Gray;
            btnAdisyonBul.FlatAppearance.BorderSize = 0;
            btnAdisyonBul.FlatStyle = FlatStyle.Flat;
            btnAdisyonBul.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAdisyonBul.ForeColor = Color.White;
            btnAdisyonBul.Location = new Point(758, 91);
            btnAdisyonBul.Margin = new Padding(3, 4, 3, 4);
            btnAdisyonBul.Name = "btnAdisyonBul";
            btnAdisyonBul.Size = new Size(166, 97);
            btnAdisyonBul.TabIndex = 14;
            btnAdisyonBul.Text = "🔍 ADİSYON\n     BUL";
            btnAdisyonBul.UseVisualStyleBackColor = false;
            btnAdisyonBul.Click += btnAdisyonBul_Click;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.Maroon;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(758, 211);
            btnYenile.Margin = new Padding(3, 4, 3, 4);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(166, 91);
            btnYenile.TabIndex = 15;
            btnYenile.Text = "KAPAT";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackColor = Color.FromArgb(128, 255, 128);
            btnYeniMusteri.FlatAppearance.BorderSize = 0;
            btnYeniMusteri.FlatStyle = FlatStyle.Flat;
            btnYeniMusteri.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            btnYeniMusteri.ForeColor = Color.White;
            btnYeniMusteri.Location = new Point(15, 431);
            btnYeniMusteri.Margin = new Padding(3, 4, 3, 4);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(183, 73);
            btnYeniMusteri.TabIndex = 16;
            btnYeniMusteri.Text = "👤+ YENİ\n     MÜŞTERİ";
            btnYeniMusteri.UseVisualStyleBackColor = false;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnMusteriSec
            // 
            btnMusteriSec.BackColor = Color.FromArgb(200, 20, 20);
            btnMusteriSec.FlatAppearance.BorderSize = 0;
            btnMusteriSec.FlatStyle = FlatStyle.Flat;
            btnMusteriSec.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            btnMusteriSec.ForeColor = Color.White;
            btnMusteriSec.Location = new Point(209, 431);
            btnMusteriSec.Margin = new Padding(3, 4, 3, 4);
            btnMusteriSec.Name = "btnMusteriSec";
            btnMusteriSec.Size = new Size(183, 73);
            btnMusteriSec.TabIndex = 17;
            btnMusteriSec.Text = "☑ MÜŞTERİ\n      SEÇ";
            btnMusteriSec.UseVisualStyleBackColor = false;
            btnMusteriSec.Click += btnMusteriSec_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackColor = Color.FromArgb(255, 192, 128);
            btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            btnMusteriGuncelle.FlatStyle = FlatStyle.Flat;
            btnMusteriGuncelle.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            btnMusteriGuncelle.ForeColor = Color.White;
            btnMusteriGuncelle.Location = new Point(404, 431);
            btnMusteriGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(194, 73);
            btnMusteriGuncelle.TabIndex = 18;
            btnMusteriGuncelle.Text = "↻ MÜŞTERİ\n  GÜNCELLE";
            btnMusteriGuncelle.UseVisualStyleBackColor = false;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnSiparisler
            // 
            btnSiparisler.BackColor = Color.FromArgb(60, 60, 90);
            btnSiparisler.FlatAppearance.BorderSize = 0;
            btnSiparisler.FlatStyle = FlatStyle.Flat;
            btnSiparisler.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            btnSiparisler.ForeColor = Color.White;
            btnSiparisler.Location = new Point(609, 431);
            btnSiparisler.Margin = new Padding(3, 4, 3, 4);
            btnSiparisler.Name = "btnSiparisler";
            btnSiparisler.Size = new Size(189, 73);
            btnSiparisler.TabIndex = 19;
            btnSiparisler.Text = "📋 SİPARİŞLER";
            btnSiparisler.UseVisualStyleBackColor = false;
            btnSiparisler.Click += btnSiparisler_Click;
            // 
            // frmMusteriAra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(943, 527);
            Controls.Add(lblAdi);
            Controls.Add(lblSoyadi);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdres);
            Controls.Add(lblEMail);
            Controls.Add(lblAdisyonId);
            Controls.Add(txtAdi);
            Controls.Add(txtSoyadi);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(txtEMail);
            Controls.Add(txtAdisyonId);
            Controls.Add(dgvCustomers);
            Controls.Add(btnAdisyonBul);
            Controls.Add(btnYenile);
            Controls.Add(btnYeniMusteri);
            Controls.Add(btnMusteriSec);
            Controls.Add(btnMusteriGuncelle);
            Controls.Add(btnSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMusteriAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteriler";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

