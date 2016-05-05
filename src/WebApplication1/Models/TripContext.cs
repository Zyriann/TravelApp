using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace WebApplication1.Models
{
    public class TripContext : DbContext
    {
        public DbSet<Trip> Trip { get; set; }
        public DbSet<Stop> Stop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString =
                Startup.Configuration["Data:DefaultConnection:ConnectionString"];
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }

        public TripContext()
        {
            Database.EnsureCreated();
        }
    }
}
