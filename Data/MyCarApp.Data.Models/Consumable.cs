namespace MyCarApp.Data.Models
{
    public class Consumable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Name { get; set; }  = null!;

        [Required]
        public int ChangedOnDistance { get; set; }

        [Required]
        public int NextChangeAfterDistance { get; set; }

        [Required]
        public bool AlertWhenForChange { get; set; }

        public Car Car { get; set; } = null!;
    }
}
