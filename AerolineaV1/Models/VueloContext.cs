using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class VueloContext : DbContext
    {
        public VueloContext(DbContextOptions<VueloContext> options):base(options)
        {}

        public DbSet<Vuelo> Vuelos { get; set; }
    }
}
