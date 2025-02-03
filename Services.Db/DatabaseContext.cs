using Microsoft.EntityFrameworkCore;
using ProductOrderService.Models;
using System;

namespace ProductOrderService.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
            Database.Migrate();
        }        
    }
}
