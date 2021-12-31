using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
 
        public User User { get; set; } = null!;

        public ICollection<Consumable> Consumables { get; set; } = new List<Consumable>();

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    }
}
