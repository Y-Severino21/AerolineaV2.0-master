using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class CLientesContext : DbContext
    {
        public CLientesContext(DbContextOptions<CLientesContext> options) : base(options)
        { }

        public DbSet<Clientes> CLientes { get; set; }
    }
}
