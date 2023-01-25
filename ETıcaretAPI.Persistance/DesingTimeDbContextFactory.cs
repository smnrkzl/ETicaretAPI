using ETıcaretAPI.Domain.Entities;
using ETıcaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETıcaretAPI.Persistance
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ETıcaretAPIDbContext>
    {
        public ETıcaretAPIDbContext CreateDbContext(string[] args)
        {
            
            DbContextOptionsBuilder<ETıcaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new ETıcaretAPIDbContext(dbContextOptionsBuilder.Options);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
//powershell ekranında db oluşturması için bunları yazdım 