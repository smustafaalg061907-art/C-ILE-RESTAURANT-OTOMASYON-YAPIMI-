namespace RestaurantOtomasyon
{
    partial class frmGiris
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlLogoBox;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnForgotPassword;

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
            cmbUsername = new ComboBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            pnlLogoBox = new Panel();
            lblLogoDakimasu = new Label();
            chkRememberMe = new CheckBox();
            btnForgotPassword = new Button();
            pnlLogoBox.SuspendLayout();
            SuspendLayout();
            // 
            // cmbUsername
            // 
            cmbUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsername.Font = new Font("Algerian", 14F, FontStyle.Italic);
            cmbUsername.FormattingEnabled = true;
            cmbUsername.Location = new Point(199, 133);
            cmbUsername.Margin = new Padding(3, 4, 3, 4);
            cmbUsername.Name = "cmbUsername";
            cmbUsername.Size = new Size(285, 39);
            cmbUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Algerian", 14F, FontStyle.Italic);
            txtPassword.Location = new Point(199, 193);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(285, 39);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Algerian", 14F, FontStyle.Bold | FontStyle.Italic);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(199, 273);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 67);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "☑  GİRİŞ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(220, 20, 60);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(410, 273);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 67);
            btnExit.TabIndex = 6;
            btnExit.Text = "\u23fb";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(16, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(171, 44);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Kullanıcı Adı";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(16, 193);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(171, 43);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Şifre";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLogoBox
            // 
            pnlLogoBox.BackColor = Color.FromArgb(64, 64, 64);
            pnlLogoBox.Controls.Add(lblLogoDakimasu);
            pnlLogoBox.Location = new Point(84, 40);
            pnlLogoBox.Margin = new Padding(3, 4, 3, 4);
            pnlLogoBox.Name = "pnlLogoBox";
            pnlLogoBox.Size = new Size(400, 73);
            pnlLogoBox.TabIndex = 0;
            // 
            // lblLogoDakimasu
            // 
            lblLogoDakimasu.BackColor = Color.Black;
            lblLogoDakimasu.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblLogoDakimasu.ForeColor = Color.Transparent;
            lblLogoDakimasu.Location = new Point(10, 18);
            lblLogoDakimasu.Name = "lblLogoDakimasu";
            lblLogoDakimasu.Size = new Size(380, 41);
            lblLogoDakimasu.TabIndex = 1;
            lblLogoDakimasu.Text = "RESTORAN OTOMASYONU GİRİŞ";
            lblLogoDakimasu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Algerian", 10F, FontStyle.Italic);
            chkRememberMe.ForeColor = Color.White;
            chkRememberMe.Location = new Point(199, 240);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(120, 27);
            chkRememberMe.TabIndex = 7;
            chkRememberMe.Text = "Beni Hatırla";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.Font = new Font("Algerian", 9F, FontStyle.Underline | FontStyle.Italic);
            btnForgotPassword.ForeColor = Color.LightGray;
            btnForgotPassword.Location = new Point(330, 240);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(154, 30);
            btnForgotPassword.TabIndex = 8;
            btnForgotPassword.Text = "Şifremi Unuttum";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(568, 376);
            Controls.Add(btnForgotPassword);
            Controls.Add(chkRememberMe);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(cmbUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlLogoBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş - Restoran Otomasyonu";
            Load += LoginForm_Load;
            pnlLogoBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblLogoDakimasu;
    }
}

