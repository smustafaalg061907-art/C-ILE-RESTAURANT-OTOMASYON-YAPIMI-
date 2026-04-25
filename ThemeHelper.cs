using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantOtomasyon.Controls
{
    public static class ThemeHelper
    {
        // Colors
        public static readonly Color BackColor = Color.FromArgb(28, 28, 28);      // Dark Gray
        public static readonly Color ElementColor = Color.FromArgb(45, 45, 45);   // Light Gray
        public static readonly Color AccentColor = Color.FromArgb(255, 160, 0);   // Amber/Orange
        public static readonly Color SuccessColor = Color.FromArgb(0, 150, 136);  // Teal/Emerald
        public static readonly Color DangerColor = Color.FromArgb(211, 47, 47);   // Muted Red
        public static readonly Color TextColor = Color.FromArgb(245, 245, 245);    // Off-white
        public static readonly Color SubTextColor = Color.FromArgb(180, 180, 180); // Muted white

        // Fonts
        public static readonly Font MainFont = new Font("Algerian", 9.5f, FontStyle.Italic);
        public static readonly Font HeaderFont = new Font("Algerian", 12f, FontStyle.Bold | FontStyle.Italic);
        public static readonly Font ButtonFont = new Font("Algerian", 10f, FontStyle.Bold | FontStyle.Italic);

        public static void Apply(Form form)
        {
            form.BackColor = BackColor;
            form.Font = MainFont;
            form.ForeColor = TextColor;

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // General styling - Font Family'yi Algerian yap, Italic ekle, Size'ı koru
                control.Font = new Font("Algerian", control.Font.Size, control.Font.Style | FontStyle.Italic);
                
                if (control is Label lbl)
                {
                    if (lbl.Tag?.ToString() == "Header")
                    {
                        // HeaderFont ataması kaldırıldı, designer boyutları korunuyor
                    }
                    else
                    {
                        lbl.ForeColor = TextColor;
                    }
                }
                else if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    // btn.Font = ButtonFont; // Designer boyutları korunuyor
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;

                    // Özel buton renkleri
                    if (btn.Name.ToLower().Contains("login") || btn.Name.ToLower().Contains("giris"))
                    {
                        btn.BackColor = Color.ForestGreen;
                    }
                    else if (btn.Name == "btnYeni" || btn.Name == "btnYeniMusteri")
                    {
                        btn.BackColor = Color.ForestGreen;
                    }
                    else if (btn.Name == "btnKaydet")
                    {
                        btn.BackColor = Color.Teal;
                    }
                    else if (btn.Name == "btnSil")
                    {
                        btn.BackColor = Color.DarkRed;
                    }
                    else if (btn.Name == "btnDegistir")
                    {
                        btn.BackColor = Color.RoyalBlue;
                    }
                    else if (btn.Name == "btnSifreDegistir")
                    {
                        btn.BackColor = Color.FromArgb(45, 45, 45); // Koyu Gri (Ekrandaki gibi)
                    }
                    else if (btn.Name == "btnRezervasyonAc")
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }
                    else if (btn.Name.ToLower().Contains("exit") || btn.Name.ToLower().Contains("cikis") || btn.Name.ToLower().Contains("geri") || btn.Text == "X")
                    {
                        btn.BackColor = Color.Crimson;
                    }
                    else if (btn.Name.StartsWith("btnCat") || (btn.Tag != null && btn.Tag.ToString() == "Category"))
                    {
                        btn.BackColor = Color.FromArgb(192, 0, 0); // Koyu Kırmızı (Premium)
                    }
                    else
                    {
                        // Koyu, abartısız gri tonu
                        btn.BackColor = Color.FromArgb(35, 35, 35);
                    }
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = ElementColor;
                    txt.ForeColor = TextColor;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = ElementColor;
                    cmb.ForeColor = TextColor;
                    cmb.FlatStyle = FlatStyle.Flat;
                }
                else if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.FromArgb(35, 35, 35);
                    dgv.GridColor = Color.FromArgb(50, 50, 50);
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.EnableHeadersVisualStyles = false;
                    
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = ButtonFont;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
                    
                    dgv.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                    dgv.DefaultCellStyle.ForeColor = Color.White;
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;

                    dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                    dgv.RowsDefaultCellStyle.ForeColor = Color.White;
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
                    dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                }
                else if (control is Panel pnl)
                {
                    if (pnl.Tag?.ToString() == "Darker")
                        pnl.BackColor = Color.FromArgb(20, 20, 20);
                    else if (pnl.Tag?.ToString() == "Lighter")
                        pnl.BackColor = ElementColor;
                    else
                        pnl.BackColor = Color.Transparent;
                }
                else if (control is GroupBox grp)
                {
                    grp.ForeColor = Color.FromArgb(211, 47, 47); // Grup başlıkları Kırmızı (Sadeleşme için)
                    ApplyToControls(grp.Controls);
                }

                // Recursive apply for containers
                if (control.HasChildren && !(control is GroupBox))
                {
                    ApplyToControls(control.Controls);
                }
            }
        }
    }
}
