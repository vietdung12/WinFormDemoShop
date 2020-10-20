using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Configurations
{
    public class ProductsBillsConfiguration : IEntityTypeConfiguration<ProductBill>
    {
        public void Configure(EntityTypeBuilder<ProductBill> builder)
        {
            builder.ToTable("ProducstBills");
            builder.HasKey(x => new {x.BillId, x.ProductId });
            

            builder.HasOne(x => x.Product).WithMany(x => x.ProductsBills).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Bill).WithMany(x => x.ProductsBills).HasForeignKey(x => x.BillId);
        }
    }
}
