using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class AvionContext : DbContext
    {
        public AvionContext(DbContextOptions<AvionContext> options):base(options)
        {}

        public DbSet<Avion> Aviones { get; set; }
    }
}
