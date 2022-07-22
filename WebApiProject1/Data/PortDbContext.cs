using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject1.Data
{
        public class PortDbContext : DbContext
        {
            public PortDbContext(DbContextOptions<PortDbContext> options) : base(options)
            {
            }

            public DbSet<PortSlots> PortSlots { get; set; }
            public DbSet<PortUsers> PortUsers { get; set; }
        }
    }

