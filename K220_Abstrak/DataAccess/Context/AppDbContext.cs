using K220_Abstrak.Models;
using Microsoft.EntityFrameworkCore;

namespace K220_Abstrak.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<MainSection> MainSections { get; set; }
        public DbSet<ServicesSection> ServicesSections { get; set; }
    }
}
