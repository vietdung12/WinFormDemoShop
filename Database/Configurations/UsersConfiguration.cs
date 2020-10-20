using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserName);
            builder.Property(x => x.UserName).HasMaxLength(100);
            builder.Property(x => x.Password).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.DisplayName).HasMaxLength(100).IsRequired();
        }
    }
}
