using ETıcaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETıcaretAPI.Persistance.Contexts
{
    //package manager console kısmında persistance seçmemiz gerekmiyor mudu evet
    public class ETıcaretAPIDbContext : DbContext
    {
        public ETıcaretAPIDbContext(DbContextOptions options) : base(options)
        {
           // DbContextOptionsBuilder<ETıcaretAPIDbContext> dbContextOptionsBuilder = new();
           // dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ETıcaretAPIDb;Integrated Security=true");
           //// return new ETıcaretAPIDbContext(dbContextOptionsBuilder.Options);
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ETıcaretAPIDb;Integrated Security=true");
        //}      

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
