using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon.Controls
{
    public class TableButton : Button
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public TableStatus Status { get; set; } = TableStatus.Empty;

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime? OrderStartTime { get; set; } = null;

        public TableButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.FromArgb(164, 198, 57);
            this.ForeColor = Color.Transparent; // Varsayılan texti gizle, biz kendimiz çiziyoruz
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = this.Width;
            int h = this.Height;

            // Masa simgesi çizimi (beyaz U şeklinde)
            int iconWidth = 110;
            int iconHeight = 25;
            int iconX = (w - iconWidth) / 2;
            int iconY = (h - iconHeight) / 2 + 5; 
            int thickness = 14; 

            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(whiteBrush, iconX, iconY, iconWidth, thickness);
                g.FillRectangle(whiteBrush, iconX, iconY, thickness, iconHeight);
                g.FillRectangle(whiteBrush, iconX + iconWidth - thickness, iconY, thickness, iconHeight);
            }

            // Masa İsmi (Örn: Masa 1)
            if (!string.IsNullOrEmpty(this.Text))
            {
                using (Font textFont = new Font("Segoe UI", 9F))
                using (SolidBrush textBrush = new SolidBrush(Color.Black))
                {
                    SizeF nameSize = g.MeasureString(this.Text, textFont);
                    float textX = (w - nameSize.Width) / 2;
                    float textY = iconY + 1; // U şeklinin tam üst çizgisine oturt
                    
                    g.DrawString(this.Text, textFont, textBrush, textX, textY);
                }
            }

            // Eğer otomasyon çalışıyorsa ve masa doluysa geçen süreyi göster
            if (Status == TableStatus.Occupied && OrderStartTime.HasValue && !this.DesignMode)
            {
                using (Font smallFont = new Font("Segoe UI", 7F))
                using (SolidBrush timeBrush = new SolidBrush(Color.Black))
                {
                    TimeSpan diff = DateTime.Now - OrderStartTime.Value;
                    string timeStr = "";
                    
                    if (diff.Days > 0) timeStr += $"{diff.Days} gun ";
                    if (diff.Hours > 0 || diff.Days > 0) timeStr += $"{diff.Hours} saat ";
                    timeStr += $"{diff.Minutes} dakika";

                    SizeF timeSize = g.MeasureString(timeStr, smallFont);
                    float timeX = (w - timeSize.Width) / 2;
                    float timeY = iconY - 18; 
                    
                    g.DrawString(timeStr, smallFont, timeBrush, timeX, timeY);
                }
            }
        }

    }
}
