using Microsoft.AspNetCore.Identity;

namespace MyCarApp.Data.Models
{
    public class User : IdentityUser
    {
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}