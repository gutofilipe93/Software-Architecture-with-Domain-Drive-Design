using IEvolveSystem.Domain.Entities;
using IEvolveSystem.Domain.Entities.ValueObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnvolveSystem.Infra.Data.EFCore.Contexts
{
    public class AppEFCoreDbContext : DbContext
    {
        public AppEFCoreDbContext(DbContextOptions<AppEFCoreDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
