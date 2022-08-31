using Microsoft.EntityFrameworkCore;

namespace IdentityTutorial.Data
{
    public class IdentityTutorialContext : DbContext
    {
        public IdentityTutorialContext(DbContextOptions<IdentityTutorialContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> applicationUsers => Set<ApplicationUser>();
        public DbSet<SuperHero>? SuperHeroes => Set<SuperHero>();
    }
}
