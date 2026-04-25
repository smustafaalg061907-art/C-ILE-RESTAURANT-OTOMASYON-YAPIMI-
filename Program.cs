using System;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;

namespace RestaurantOtomasyon
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanını başlat
            using (var context = new ApplicationDbContext())
            {
                DbInitializer.Initialize(context);
            }

            Application.Run(new frmGiris());
        }
    }
}
