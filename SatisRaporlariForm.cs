using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RestaurantOtomasyon.Data;

namespace RestaurantOtomasyon
{
    public partial class SatisRaporlariForm : Form
    {
        private string secilenKategori = "TÜM ÜRÜNLER";

        public SatisRaporlariForm()
        {
            InitializeComponent();
            RestaurantOtomasyon.Controls.ThemeHelper.Apply(this);
        }

        private void SatisRaporlariForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 43, 43);

            // Chart ayarla
            SetupChart();

            // Tarih ayarla
            dtpBaslangic.Value = DateTime.Today.AddDays(-30);
            dtpBitis.Value = DateTime.Today;

            // Veri yükle
            LoadData();
        }

        private void SetupChart()
        {
            chartSatislar.ChartAreas.Clear();
            chartSatislar.Legends.Clear();
            chartSatislar.Series.Clear();

            // Chart arka plan
            chartSatislar.BackColor = Color.FromArgb(50, 50, 50);

            // ChartArea
            ChartArea area = new ChartArea("ChartArea1");
            area.BackColor = Color.FromArgb(40, 40, 40);
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisX.LineColor = Color.White;
            area.AxisY.LineColor = Color.White;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            // area.AxisY.Maximum ve Interval ayarlarını KALIYORUZ! (Otomatik ölçeklensin)
            chartSatislar.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend("Legend1");
            legend.Alignment = StringAlignment.Far;
            legend.Docking = Docking.Top;
            legend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            legend.BackColor = Color.Transparent;
            chartSatislar.Legends.Add(legend);
        }

        private void KategoriButon_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                secilenKategori = btn.Tag?.ToString() ?? "TÜM ÜRÜNLER";
                LoadData();
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date.AddDays(1).AddTicks(-1);

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var query = from oi in context.OrderItems
                                join o in context.Orders on oi.OrderId equals o.Id
                                join p in context.Products on oi.ProductId equals p.Id
                                join c in context.Categories on p.CategoryId equals c.Id
                                where o.OrderDate >= baslangic && o.OrderDate <= bitis && o.IsCompleted
                                select new { CategoryName = c.Name, ProductName = p.Name, oi.Quantity };

                    if (secilenKategori != "TÜM ÜRÜNLER")
                    {
                        query = query.Where(q => q.CategoryName.ToUpper() == secilenKategori.ToUpper());
                    }
                    
                    var groupedData = query.GroupBy(q => q.ProductName)
                                           .Select(g => new { Urun = g.Key, Adet = g.Sum(x => x.Quantity) })
                                           .OrderByDescending(x => x.Adet)
                                           .Take(15) 
                                           .ToList();

                    // Finansal Özet
                    var completedOrders = context.Orders.Where(o => o.OrderDate >= baslangic && o.OrderDate <= bitis && o.IsCompleted).ToList();
                    decimal totalRevenue = completedOrders.Sum(o => o.TotalAmount);
                    decimal cashRevenue = completedOrders.Where(o => o.PaymentMethod == "Nakit").Sum(o => o.TotalAmount);
                    decimal cardRevenue = completedOrders.Where(o => o.PaymentMethod == "Kredi Kartı").Sum(o => o.TotalAmount);
                    
                    decimal totalExpenses = context.Expenses.Where(e => e.Date >= baslangic && e.Date <= bitis).Sum(e => e.Amount);
                    decimal netProfit = totalRevenue - totalExpenses;

                    lblTotalRevenue.Text = $"Toplam: {totalRevenue:N2} TL";
                    lblCash.Text = $"Nakit: {cashRevenue:N2} TL";
                    lblCard.Text = $"Kart: {cardRevenue:N2} TL";
                    lblExpenses.Text = $"Gider: {totalExpenses:N2} TL";
                    lblNetProfit.Text = $"NET: {netProfit:N2} TL";
                    lblNetProfit.ForeColor = netProfit >= 0 ? Color.LimeGreen : Color.FromArgb(255, 50, 50);

                    if (groupedData.Count > 0)
                    {
                        DrawChart(groupedData.Select(x => (double)x.Adet).ToArray(), groupedData.Select(x => x.Urun).ToArray());
                    }
                    else
                    {
                        DrawDummyChart();
                    }
                }
            }
            catch (Exception)
            {
                DrawDummyChart();
            }
        }

        private void DrawDummyChart()
        {
            DrawChart(new double[] { 95, 82, 82, 48, 80, 85, 60, 35 }, 
                      new string[] { "Kebap", "Döner", "Lahmacun", "Pide", "Salata", "Ayran", "Kola", "Su" });
        }

        private void DrawChart(double[] values, string[] labels)
        {
            chartSatislar.Series.Clear();

            Series series = new Series("Satışlar");
            series.ChartArea = "ChartArea1"; // Explicitly bind to the created area
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(255, 200, 37);  // Sarı/Gold renk
            series.IsValueShownAsLabel = true;
            series["PointWidth"] = "0.6";
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series.LabelForeColor = Color.White;

            for (int i = 0; i < values.Length; i++)
            {
                series.Points.AddXY(labels[i], values[i]);
            }

            chartSatislar.Series.Add(series);
        }
    }
}
