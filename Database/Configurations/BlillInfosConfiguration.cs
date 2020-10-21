using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Configurations
{
    public class BlillInfosConfiguration : IEntityTypeConfiguration<BillInfo>
    {
        public void Configure(EntityTypeBuilder<BillInfo> builder)
        {
            builder.ToTable("BillInfos");
            builder.HasKey(x => new {x.BillId, x.ProductId });
            builder.Property(x => x.Quantity).IsRequired();
            builder.HasOne(x => x.Bill).WithMany(x => x.BillInfos).HasForeignKey(x => x.BillId);
            builder.HasOne(x => x.Product).WithMany(x => x.BillInfos).HasForeignKey(x => x.ProductId);
            
        }
    }
}
