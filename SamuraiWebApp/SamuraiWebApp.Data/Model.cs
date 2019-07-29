using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace SamuraiWebApp.Data
{
    public class SamuraiContext : DbContext
    {
        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }
        public DbSet<Samurai> Samurais { get; set; }

    }
    public class Samurai
    {
        
    }
}
