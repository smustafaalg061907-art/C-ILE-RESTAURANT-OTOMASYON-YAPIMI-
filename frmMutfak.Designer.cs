namespace RestaurantOtomasyon
{
    partial class frmMutfak
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblGidaKategorisi;
        private System.Windows.Forms.ComboBox cmbGidaKategorisi;
        private System.Windows.Forms.Label lblGidaAdi;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.Label lblGidaFiyati;
        private System.Windows.Forms.TextBox txtGidaFiyati;
        private System.Windows.Forms.Button btnUrunKategoriEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnKapat;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGidaKategorisi = new System.Windows.Forms.Label();
            this.cmbGidaKategorisi = new System.Windows.Forms.ComboBox();
            this.lblGidaAdi = new System.Windows.Forms.Label();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.lblGidaFiyati = new System.Windows.Forms.Label();
            this.txtGidaFiyati = new System.Windows.Forms.TextBox();
            this.btnUrunKategoriEkle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGidaKategorisi
            // 
            this.lblGidaKategorisi.AutoSize = true;
            this.lblGidaKategorisi.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.lblGidaKategorisi.ForeColor = System.Drawing.Color.White;
            this.lblGidaKategorisi.Location = new System.Drawing.Point(30, 30);
            this.lblGidaKategorisi.Name = "lblGidaKategorisi";
            this.lblGidaKategorisi.Size = new System.Drawing.Size(160, 28);
            this.lblGidaKategorisi.TabIndex = 0;
            this.lblGidaKategorisi.Text = "Gıda Kategorisi :";
            // 
            // cmbGidaKategorisi
            // 
            this.cmbGidaKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGidaKategorisi.Font = new System.Drawing.Font("Algerian", 12F);
            this.cmbGidaKategorisi.Location = new System.Drawing.Point(210, 26);
            this.cmbGidaKategorisi.Name = "cmbGidaKategorisi";
            this.cmbGidaKategorisi.Size = new System.Drawing.Size(280, 36);
            this.cmbGidaKategorisi.TabIndex = 1;
            // 
            // lblGidaAdi
            // 
            this.lblGidaAdi.AutoSize = true;
            this.lblGidaAdi.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.lblGidaAdi.ForeColor = System.Drawing.Color.White;
            this.lblGidaAdi.Location = new System.Drawing.Point(84, 80);
            this.lblGidaAdi.Name = "lblGidaAdi";
            this.lblGidaAdi.Size = new System.Drawing.Size(105, 28);
            this.lblGidaAdi.TabIndex = 2;
            this.lblGidaAdi.Text = "Gıda Adı :";
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Font = new System.Drawing.Font("Algerian", 12F);
            this.txtGidaAdi.Location = new System.Drawing.Point(210, 76);
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(280, 34);
            this.txtGidaAdi.TabIndex = 3;
            // 
            // lblGidaFiyati
            // 
            this.lblGidaFiyati.AutoSize = true;
            this.lblGidaFiyati.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.lblGidaFiyati.ForeColor = System.Drawing.Color.White;
            this.lblGidaFiyati.Location = new System.Drawing.Point(68, 130);
            this.lblGidaFiyati.Name = "lblGidaFiyati";
            this.lblGidaFiyati.Size = new System.Drawing.Size(122, 28);
            this.lblGidaFiyati.TabIndex = 4;
            this.lblGidaFiyati.Text = "Gıda Fiyatı :";
            // 
            // txtGidaFiyati
            // 
            this.txtGidaFiyati.Font = new System.Drawing.Font("Algerian", 12F);
            this.txtGidaFiyati.Location = new System.Drawing.Point(210, 126);
            this.txtGidaFiyati.Name = "txtGidaFiyati";
            this.txtGidaFiyati.Size = new System.Drawing.Size(280, 34);
            this.txtGidaFiyati.TabIndex = 5;
            // 
            // btnUrunKategoriEkle
            // 
            this.btnUrunKategoriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUrunKategoriEkle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUrunKategoriEkle.FlatAppearance.BorderSize = 1;
            this.btnUrunKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunKategoriEkle.Font = new System.Drawing.Font("Algerian", 9F);
            this.btnUrunKategoriEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunKategoriEkle.Location = new System.Drawing.Point(520, 26);
            this.btnUrunKategoriEkle.Name = "btnUrunKategoriEkle";
            this.btnUrunKategoriEkle.Size = new System.Drawing.Size(140, 36);
            this.btnUrunKategoriEkle.TabIndex = 6;
            this.btnUrunKategoriEkle.Text = "Ürün Kategori Ekle";
            this.btnUrunKategoriEkle.UseVisualStyleBackColor = false;
            this.btnUrunKategoriEkle.Click += new System.EventHandler(this.btnUrunKategoriEkle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Red;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(70, 200);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(175, 70);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnDegistir.FlatAppearance.BorderSize = 0;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.btnDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDegistir.Location = new System.Drawing.Point(255, 200);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(195, 70);
            this.btnDegistir.TabIndex = 8;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btnBul.FlatAppearance.BorderSize = 0;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.btnBul.ForeColor = System.Drawing.Color.White;
            this.btnBul.Location = new System.Drawing.Point(460, 200);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(175, 70);
            this.btnBul.TabIndex = 9;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(645, 200);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(175, 70);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUrunler.ColumnHeadersHeight = 40;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Algerian", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUrunler.EnableHeadersVisualStyles = false;
            this.dgvUrunler.Location = new System.Drawing.Point(255, 290);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 35;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(565, 310);
            this.dgvUrunler.TabIndex = 11;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(14, 548);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(53, 52);
            this.btnYenile.TabIndex = 12;
            this.btnYenile.Text = "↻";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(73, 548);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(53, 52);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "\u23fb";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // MutfakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnUrunKategoriEkle);
            this.Controls.Add(this.txtGidaFiyati);
            this.Controls.Add(this.lblGidaFiyati);
            this.Controls.Add(this.txtGidaAdi);
            this.Controls.Add(this.lblGidaAdi);
            this.Controls.Add(this.cmbGidaKategorisi);
            this.Controls.Add(this.lblGidaKategorisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MutfakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutfak - Gıda Yönetimi";
            this.Load += new System.EventHandler(this.MutfakForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

