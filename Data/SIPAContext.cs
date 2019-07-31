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
    }
