using Microsoft.AspNetCore.Identity;

namespace MSFortRestaurant.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ICollection<Order> Orders { get; set; }
    }
}
