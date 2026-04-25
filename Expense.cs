using System;

namespace RestaurantOtomasyon.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Category { get; set; } = "Genel"; // Mutfak, Maaş, Kira, Diğer
    }
}
