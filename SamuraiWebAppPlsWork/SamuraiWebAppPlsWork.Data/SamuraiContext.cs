using SamuraiWebAppPlsWork.Domain;
using Microsoft.EntityFrameworkCore;

namespace SamuraiWebAppPlsWork.Data
{
    public class SamuraiContext : DbContext
    {
        public SamuraiContext(DbContextOptions<SamuraiContext> options) : base(options) { }
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
    }
}
