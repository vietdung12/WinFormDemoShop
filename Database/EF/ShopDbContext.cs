using Database.Configurations;
using Database.Entities;
using Database.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.EF
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new BillsConfiguration());
            modelBuilder.ApplyConfiguration(new BlillInfosConfiguration());

            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillInfo> BillInfos { get; set; }
    }
}
