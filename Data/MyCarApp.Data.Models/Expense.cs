namespace MyCarApp.Data.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? Note { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public Car Car { get; set; } = null!;
    }
}
