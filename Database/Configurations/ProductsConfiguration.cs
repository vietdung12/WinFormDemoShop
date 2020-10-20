using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();

            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
