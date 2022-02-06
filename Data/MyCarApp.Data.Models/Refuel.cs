namespace MyCarApp.Data.Models
{
    public class Refuel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Liters { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal PriceLiter { get; set; }

        public string? Note { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public Car Car { get; set; } = null!;
    }
}
