namespace RestaurantOtomasyon
{
    partial class frmRaporlar
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblRaporBaslik;
        private System.Windows.Forms.Label lblToplamOzet;
        private System.Windows.Forms.Button btnYenile;

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
            btnAylikRapor = new Button();
            btnZRaporu = new Button();
            dgvRapor = new DataGridView();
            pnlToolbar = new Panel();
            lblAy = new Label();
            cmbAy = new ComboBox();
            lblYil = new Label();
            cmbYil = new ComboBox();
            lblRaporBaslik = new Label();
            lblToplamOzet = new Label();
            btnYenile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.BackColor = Color.FromArgb(0, 174, 239);
            btnAylikRapor.FlatAppearance.BorderSize = 0;
            btnAylikRapor.FlatStyle = FlatStyle.Flat;
            btnAylikRapor.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAylikRapor.ForeColor = Color.White;
            btnAylikRapor.Location = new Point(14, 50);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(170, 80);
            btnAylikRapor.TabIndex = 0;
            btnAylikRapor.Text = "AYLIK\r\nRAPOR";
            btnAylikRapor.UseVisualStyleBackColor = false;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // btnZRaporu
            // 
            btnZRaporu.BackColor = Color.FromArgb(0, 163, 0);
            btnZRaporu.FlatAppearance.BorderSize = 0;
            btnZRaporu.FlatStyle = FlatStyle.Flat;
            btnZRaporu.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            btnZRaporu.ForeColor = Color.White;
            btnZRaporu.Location = new Point(14, 140);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new Size(170, 80);
            btnZRaporu.TabIndex = 1;
            btnZRaporu.Text = "RAPOR";
            btnZRaporu.UseVisualStyleBackColor = false;
            btnZRaporu.Click += btnZRaporu_Click;
            // 
            // dgvRapor
            // 
            dgvRapor.AllowUserToAddRows = false;
            dgvRapor.AllowUserToDeleteRows = false;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.BackgroundColor = Color.White;
            dgvRapor.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 80, 150);
            dataGridViewCellStyle1.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRapor.ColumnHeadersHeight = 38;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Algerian", 10F, FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 100, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRapor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRapor.EnableHeadersVisualStyles = false;
            dgvRapor.Location = new Point(195, 96);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            dgvRapor.RowHeadersVisible = false;
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.RowTemplate.Height = 32;
            dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapor.Size = new Size(761, 420);
            dgvRapor.TabIndex = 4;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(55, 55, 55);
            pnlToolbar.Controls.Add(lblAy);
            pnlToolbar.Controls.Add(cmbAy);
            pnlToolbar.Controls.Add(lblYil);
            pnlToolbar.Controls.Add(cmbYil);
            pnlToolbar.Location = new Point(195, 12);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(745, 40);
            pnlToolbar.TabIndex = 2;
            // 
            // lblAy
            // 
            lblAy.AutoSize = true;
            lblAy.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            lblAy.ForeColor = Color.White;
            lblAy.Location = new Point(10, 8);
            lblAy.Name = "lblAy";
            lblAy.Size = new Size(36, 23);
            lblAy.TabIndex = 0;
            lblAy.Text = "Ay:";
            // 
            // cmbAy
            // 
            cmbAy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAy.Font = new Font("Algerian", 10F, FontStyle.Italic);
            cmbAy.Location = new Point(54, 5);
            cmbAy.Name = "cmbAy";
            cmbAy.Size = new Size(140, 31);
            cmbAy.TabIndex = 1;
            // 
            // lblYil
            // 
            lblYil.AutoSize = true;
            lblYil.Font = new Font("Algerian", 10F, FontStyle.Bold | FontStyle.Italic);
            lblYil.ForeColor = Color.White;
            lblYil.Location = new Point(200, 8);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(35, 23);
            lblYil.TabIndex = 2;
            lblYil.Text = "Yıl:";
            // 
            // cmbYil
            // 
            cmbYil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYil.Font = new Font("Algerian", 10F, FontStyle.Italic);
            cmbYil.Location = new Point(241, 5);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(100, 31);
            cmbYil.TabIndex = 3;
            // 
            // lblRaporBaslik
            // 
            lblRaporBaslik.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            lblRaporBaslik.ForeColor = Color.FromArgb(0, 174, 239);
            lblRaporBaslik.Location = new Point(195, 58);
            lblRaporBaslik.Name = "lblRaporBaslik";
            lblRaporBaslik.Size = new Size(745, 35);
            lblRaporBaslik.TabIndex = 3;
            lblRaporBaslik.Text = "Rapor seçiniz...";
            lblRaporBaslik.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToplamOzet
            // 
            lblToplamOzet.BackColor = Color.FromArgb(55, 55, 55);
            lblToplamOzet.Font = new Font("Algerian", 11F, FontStyle.Bold | FontStyle.Italic);
            lblToplamOzet.ForeColor = Color.FromArgb(0, 255, 128);
            lblToplamOzet.Location = new Point(195, 520);
            lblToplamOzet.Name = "lblToplamOzet";
            lblToplamOzet.Size = new Size(745, 35);
            lblToplamOzet.TabIndex = 5;
            lblToplamOzet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(128, 255, 128);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(14, 510);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(53, 52);
            btnYenile.TabIndex = 6;
            btnYenile.Text = "↻";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // frmRaporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(979, 575);
            Controls.Add(btnYenile);
            Controls.Add(lblToplamOzet);
            Controls.Add(dgvRapor);
            Controls.Add(lblRaporBaslik);
            Controls.Add(pnlToolbar);
            Controls.Add(btnZRaporu);
            Controls.Add(btnAylikRapor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRaporlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlar";
            Load += RaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ResumeLayout(false);
        }
    }
}

