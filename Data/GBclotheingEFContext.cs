using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GBclotheingEF.Models;

namespace GBclotheingEF.Data
{
    public class GBclotheingEFContext : DbContext
    {
        public GBclotheingEFContext (DbContextOptions<GBclotheingEFContext> options)
            : base(options)
        {
        }

        public DbSet<GBclotheingEF.Models.Product> Product { get; set; }

        public DbSet<GBclotheingEF.Models.Brand> Brand { get; set; }

        public DbSet<GBclotheingEF.Models.Accessorie> Accessorie { get; set; }
    }
}
