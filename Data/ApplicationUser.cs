using Microsoft.AspNetCore.Identity;

namespace IdentityTutorial.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}
