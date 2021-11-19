using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarMarket.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Market> Market { get; set; }

        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
