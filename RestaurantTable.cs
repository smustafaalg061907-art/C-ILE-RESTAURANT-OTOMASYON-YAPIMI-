namespace RestaurantOtomasyon.Models
{
    public enum TableStatus
    {
        Empty = 0,
        Occupied = 1,
        Reserved = 2
    }

    public class RestaurantTable
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TableStatus Status { get; set; } = TableStatus.Empty;
    }
}
