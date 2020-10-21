using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {           
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserName = "admin",
                    Password = "Admin@123",
                    DisplayName = "Admin"
                });

            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Kính mát"                   
               });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "kính 50k",
                    Price = 50000,
                    Quantity = 50,
                    CategoryId = 1
                });

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 2,
                   Name = "kính 60k",
                   Price = 60000,
                   Quantity = 60,
                   CategoryId = 1
               });
        }
    }
}
