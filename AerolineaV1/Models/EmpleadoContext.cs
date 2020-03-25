using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AerolineaV1.Models;

namespace AerolineaV1.Models
{
    public class EmpleadoContext : DbContext 
    {
        public EmpleadoContext(DbContextOptions<EmpleadoContext> options):base(options)
        {}
        
        public DbSet<Empleado> Empleados { get; set; }
    }
}
