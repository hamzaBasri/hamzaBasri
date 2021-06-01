using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DAL
{
    public class DB : DbContext
    {
        public DB(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductProperty> ProductPropertys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Models.OrderItem> ProductOrders { get; set; }
        public DbSet<Models.Property> Propertys { get; set; }
        public DbSet<PropertyOption> PropertyOptions { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
