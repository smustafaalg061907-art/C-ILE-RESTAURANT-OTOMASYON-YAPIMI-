namespace RestaurantOtomasyon.Models
{
    using System;

    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantTableId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberOfPeople { get; set; }
        public string Note { get; set; } = string.Empty;
        
        public Customer Customer { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }
}
