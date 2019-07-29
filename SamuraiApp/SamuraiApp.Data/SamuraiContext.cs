using SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public SamuraiContext(DbContextOptions<SamuraiContext> options) : base(options) { }
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new { s.BattleId, s.SamuraiId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
