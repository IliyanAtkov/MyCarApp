namespace MyCarApp.Data.Models
{
    public class Reminder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        public bool IsFinished { get; set; }

        public bool SendReminder { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public Car Car { get; set; } = null!;
    }
}
