using System.Linq;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // GELİŞTİRME AŞAMASINDA: Veritabanını her seferinde sıfırla (Yeni personelin gelmesi için)
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Zaten veri varsa tekrar ekleme
            if (context.Users.Any())
                return;

            var users = new User[]
            {
                new User{Username="mustafa",FirstName="Mustafa",LastName="ALAĞEYİK",Password="1234",Role="Müdür"},
                new User{Username="admin",FirstName="Admin",LastName="Sistem",Password="1234",Role="Müdür"}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category{Name="YİYECEK", ColorHex="#f44336"},
                new Category{Name="İÇECEK", ColorHex="#ff9800"},
                new Category{Name="SALATA", ColorHex="#4caf50"},
                new Category{Name="ÇORBA", ColorHex="#ffeb3b"},
                new Category{Name="TATLI", ColorHex="#03a9f4"},
                new Category{Name="ARA SICAK", ColorHex="#9c27b0"}
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var yiyecekId = context.Categories.First(c => c.Name == "YİYECEK").Id;
            var icecekId = context.Categories.First(c => c.Name == "İÇECEK").Id;
            var salataId = context.Categories.First(c => c.Name == "SALATA").Id;
            var corbaId = context.Categories.First(c => c.Name == "ÇORBA").Id;
            var tatliId = context.Categories.First(c => c.Name == "TATLI").Id;
            var araSicakId = context.Categories.First(c => c.Name == "ARA SICAK").Id;

            var products = new Product[]
            {
                new Product{Name="Adana Kebap",Price=220,CategoryId=yiyecekId},
                new Product{Name="Urfa Kebap",Price=210,CategoryId=yiyecekId},
                new Product{Name="Kuzu Şiş",Price=280,CategoryId=yiyecekId},
                new Product{Name="Kola",Price=45,CategoryId=icecekId},
                new Product{Name="Ayran",Price=25,CategoryId=icecekId},
                new Product{Name="Şalgam",Price=30,CategoryId=icecekId},
                new Product{Name="Çoban Salata",Price=80,CategoryId=salataId},
                new Product{Name="Mevsim Salata",Price=75,CategoryId=salataId},
                new Product{Name="Mercimek Çorbası",Price=60,CategoryId=corbaId},
                new Product{Name="Ezogelin Çorbası",Price=65,CategoryId=corbaId},
                new Product{Name="Künefe",Price=120,CategoryId=tatliId},
                new Product{Name="Sütlaç",Price=85,CategoryId=tatliId},
                new Product{Name="İçli Köfte",Price=50,CategoryId=araSicakId},
                new Product{Name="Paçanga Böreği",Price=70,CategoryId=araSicakId}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            for (int i = 1; i <= 10; i++)
            {
                context.RestaurantTables.Add(new RestaurantTable { Name = $"Masa {i}", Status = TableStatus.Empty });
            }
            context.SaveChanges();

            var expenses = new Expense[]
            {
                new Expense { Title = "Kira Ödemesi", Amount = 15000, Category = "Kira", Date = System.DateTime.Today.AddDays(-5) },
                new Expense { Title = "Mutfak Alışverişi", Amount = 2500, Category = "Mutfak", Date = System.DateTime.Today.AddDays(-2) },
                new Expense { Title = "Elektrik Faturası", Amount = 1200, Category = "Gider", Date = System.DateTime.Today.AddDays(-1) }
            };
            foreach (Expense e in expenses)
            {
                context.Expenses.Add(e);
            }
            context.SaveChanges();
        }
    }
}
