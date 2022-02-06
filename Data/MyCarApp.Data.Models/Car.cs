namespace MyCarApp.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int InitialRegistration { get; set; }

        [Required]
        public DateTime DateBought { get; set; }

        [Required]
        public int InitialMileage { get; set; }

        [Required]
        public int CurrentMileage { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Required]
        public User User { get; set; } = null!;

        public ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();

        public ICollection<Refuel> Refuels { get; set; } = new List<Refuel>();

        public ICollection<Consumable> Consumables { get; set; } = new List<Consumable>();

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
