using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIPA.Models;

    public class SIPAContext : DbContext
    {
        public SIPAContext (DbContextOptions<SIPAContext> options)
            : base(options)
        {
        }

        public DbSet<SIPA.Models.Autoservicio> Autoservicio { get; set; }

        public DbSet<SIPA.Models.Cliente> Cliente { get; set; }

        public DbSet<SIPA.Models.Empleado> Empleado { get; set; }

        public DbSet<SIPA.Models.Proveedor> Proveedor { get; set; }

        public DbSet<SIPA.Models.Articulo> Articulo { get; set; }
    }
