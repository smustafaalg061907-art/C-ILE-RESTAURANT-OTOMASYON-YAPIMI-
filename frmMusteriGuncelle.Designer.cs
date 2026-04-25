namespace RestaurantOtomasyon
{
    partial class frmMusteriGuncelle
    {
        private System.ComponentModel.IContainer components = null;

        // Top search fields (visual match with CustomersForm)
        private System.Windows.Forms.Label lblTopAdi;
        private System.Windows.Forms.Label lblTopSoyadi;
        private System.Windows.Forms.Label lblTopTelefon;
        private System.Windows.Forms.Label lblTopAdres;
        private System.Windows.Forms.Label lblTopEMail;
        private System.Windows.Forms.Label lblTopAdisyonId;
        private System.Windows.Forms.TextBox txtTopAdi;
        private System.Windows.Forms.TextBox txtTopSoyadi;
        private System.Windows.Forms.TextBox txtTopTelefon;
        private System.Windows.Forms.TextBox txtTopAdres;
        private System.Windows.Forms.TextBox txtTopEMail;
        private System.Windows.Forms.TextBox txtTopAdisyonId;

        // Center edit fields
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;

        // Bottom buttons
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeri;

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
            this.lblTopAdi = new System.Windows.Forms.Label();
            this.lblTopSoyadi = new System.Windows.Forms.Label();
            this.lblTopTelefon = new System.Windows.Forms.Label();
            this.lblTopAdres = new System.Windows.Forms.Label();
            this.lblTopEMail = new System.Windows.Forms.Label();
            this.lblTopAdisyonId = new System.Windows.Forms.Label();
            this.txtTopAdi = new System.Windows.Forms.TextBox();
            this.txtTopSoyadi = new System.Windows.Forms.TextBox();
            this.txtTopTelefon = new System.Windows.Forms.TextBox();
            this.txtTopAdres = new System.Windows.Forms.TextBox();
            this.txtTopEMail = new System.Windows.Forms.TextBox();
            this.txtTopAdisyonId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== TOP SECTION (same as CustomersForm) =====

            // lblTopAdi
            this.lblTopAdi.AutoSize = true;
            this.lblTopAdi.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopAdi.ForeColor = System.Drawing.Color.White;
            this.lblTopAdi.Location = new System.Drawing.Point(17, 13);
            this.lblTopAdi.Name = "lblTopAdi";
            this.lblTopAdi.Size = new System.Drawing.Size(45, 25);
            this.lblTopAdi.Text = "ADI";

            // lblTopSoyadi
            this.lblTopSoyadi.AutoSize = true;
            this.lblTopSoyadi.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopSoyadi.ForeColor = System.Drawing.Color.White;
            this.lblTopSoyadi.Location = new System.Drawing.Point(166, 13);
            this.lblTopSoyadi.Name = "lblTopSoyadi";
            this.lblTopSoyadi.Size = new System.Drawing.Size(81, 25);
            this.lblTopSoyadi.Text = "SOYADI";

            // lblTopTelefon
            this.lblTopTelefon.AutoSize = true;
            this.lblTopTelefon.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopTelefon.ForeColor = System.Drawing.Color.White;
            this.lblTopTelefon.Location = new System.Drawing.Point(320, 13);
            this.lblTopTelefon.Name = "lblTopTelefon";
            this.lblTopTelefon.Size = new System.Drawing.Size(92, 25);
            this.lblTopTelefon.Text = "TELEFON";

            // lblTopEMail
            this.lblTopEMail.AutoSize = true;
            this.lblTopEMail.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopEMail.ForeColor = System.Drawing.Color.White;
            this.lblTopEMail.Location = new System.Drawing.Point(473, 13);
            this.lblTopEMail.Name = "lblTopEMail";
            this.lblTopEMail.Size = new System.Drawing.Size(77, 25);
            this.lblTopEMail.Text = "E-MAIL";

            // lblTopAdisyonId
            this.lblTopAdisyonId.AutoSize = true;
            this.lblTopAdisyonId.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopAdisyonId.ForeColor = System.Drawing.Color.White;
            this.lblTopAdisyonId.Location = new System.Drawing.Point(626, 13);
            this.lblTopAdisyonId.Name = "lblTopAdisyonId";
            this.lblTopAdisyonId.Size = new System.Drawing.Size(122, 25);
            this.lblTopAdisyonId.Text = "ADİSYON ID";

            // lblTopAdres
            this.lblTopAdres.AutoSize = true;
            this.lblTopAdres.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopAdres.ForeColor = System.Drawing.Color.White;
            this.lblTopAdres.Location = new System.Drawing.Point(760, 13);
            this.lblTopAdres.Name = "lblTopAdres";
            this.lblTopAdres.Size = new System.Drawing.Size(72, 25);
            this.lblTopAdres.Text = "ADRES";

            // txtTopAdi
            this.txtTopAdi.Font = new System.Drawing.Font("Algerian", 10F);
            this.txtTopAdi.Location = new System.Drawing.Point(17, 47);
            this.txtTopAdi.Name = "txtTopAdi";
            this.txtTopAdi.Size = new System.Drawing.Size(137, 30);
            this.txtTopAdi.ReadOnly = true;

            // txtTopSoyadi
            this.txtTopSoyadi.Font = new System.Drawing.Font("Algerian", 10F);
            this.txtTopSoyadi.Location = new System.Drawing.Point(166, 47);
            this.txtTopSoyadi.Name = "txtTopSoyadi";
            this.txtTopSoyadi.Size = new System.Drawing.Size(137, 30);
            this.txtTopSoyadi.ReadOnly = true;

            // txtTopTelefon
            this.txtTopTelefon.Font = new System.Drawing.Font("Algerian", 10F);
            this.txtTopTelefon.Location = new System.Drawing.Point(320, 47);
            this.txtTopTelefon.Name = "txtTopTelefon";
            this.txtTopTelefon.Size = new System.Drawing.Size(137, 30);
            this.txtTopTelefon.ReadOnly = true;

            // txtTopEMail
            this.txtTopEMail.Font = new System.Drawing.Font("Algerian", 10F);
            this.txtTopEMail.Location = new System.Drawing.Point(473, 47);
            this.txtTopEMail.Name = "txtTopEMail";
            this.txtTopEMail.Size = new System.Drawing.Size(137, 30);
            this.txtTopEMail.ReadOnly = true;

            // txtTopAdisyonId
            this.txtTopAdisyonId.Font = new System.Drawing.Font("Algerian", 10F);
            this.txtTopAdisyonId.Location = new System.Drawing.Point(626, 47);
            this.txtTopAdisyonId.Name = "txtTopAdisyonId";
            this.txtTopAdisyonId.Size = new System.Drawing.Size(122, 30);
            this.txtTopAdisyonId.ReadOnly = true;

            // txtTopAdres
            this.txtTopAdres.Font = new System.Drawing.Font("Algerian", 10F);
            this.txtTopAdres.Location = new System.Drawing.Point(760, 47);
            this.txtTopAdres.Name = "txtTopAdres";
            this.txtTopAdres.Size = new System.Drawing.Size(151, 30);
            this.txtTopAdres.ReadOnly = true;

            // ===== CENTER EDIT FIELDS =====

            // lblName
            this.lblName.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(100, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 32);
            this.lblName.Text = "Müşteri Adı :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtName
            this.txtName.Font = new System.Drawing.Font("Algerian", 13F);
            this.txtName.Location = new System.Drawing.Point(360, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 36);

            // lblSurname
            this.lblSurname.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Bold);
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(100, 152);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(250, 32);
            this.lblSurname.Text = "Müşteri Soyadı :";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtSurname
            this.txtSurname.Font = new System.Drawing.Font("Algerian", 13F);
            this.txtSurname.Location = new System.Drawing.Point(360, 150);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(280, 36);

            // lblPhone
            this.lblPhone.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(100, 199);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(250, 32);
            this.lblPhone.Text = "Telefon :";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Algerian", 13F);
            this.txtPhone.Location = new System.Drawing.Point(360, 197);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(280, 36);

            // lblAddress
            this.lblAddress.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(100, 248);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(250, 32);
            this.lblAddress.Text = "Adres :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtAddress
            this.txtAddress.Font = new System.Drawing.Font("Algerian", 11F);
            this.txtAddress.Location = new System.Drawing.Point(360, 246);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 90);

            // lblEmail
            this.lblEmail.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(100, 355);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(250, 32);
            this.lblEmail.Text = "E-Mail :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Algerian", 13F);
            this.txtEmail.Location = new System.Drawing.Point(360, 353);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 36);

            // ===== BOTTOM BUTTONS =====

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 130, 130);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(17, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 73);
            this.btnSave.Text = "👤+ YENİ\n     MÜŞTERİ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnKapat
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(200, 20, 20);
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(211, 433);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(183, 73);
            this.btnKapat.Text = "☑ MÜŞTERİ\n      SEÇ";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // btnGeri
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.Font = new System.Drawing.Font("Algerian", 28F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(810, 433);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(115, 73);
            this.btnGeri.Text = "↻";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);

            // ===== FORM =====

            // CustomerEditForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(943, 527);
            // Top labels
            this.Controls.Add(this.lblTopAdi);
            this.Controls.Add(this.lblTopSoyadi);
            this.Controls.Add(this.lblTopTelefon);
            this.Controls.Add(this.lblTopEMail);
            this.Controls.Add(this.lblTopAdisyonId);
            this.Controls.Add(this.lblTopAdres);
            // Top textboxes
            this.Controls.Add(this.txtTopAdi);
            this.Controls.Add(this.txtTopSoyadi);
            this.Controls.Add(this.txtTopTelefon);
            this.Controls.Add(this.txtTopEMail);
            this.Controls.Add(this.txtTopAdisyonId);
            this.Controls.Add(this.txtTopAdres);
            // Center edit fields
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            // Bottom buttons
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Düzenle";
            this.Load += new System.EventHandler(this.frmMusteriGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

