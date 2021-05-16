using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    public class ProductPropertyConfiguration : IEntityTypeConfiguration<ProductProperty>
    {
        public void Configure(EntityTypeBuilder<ProductProperty> builder)
        {
            builder.ToTable("ProductProperty");
            builder.HasKey(pp => new { pp.ProductId, pp.PropertyId });
            builder.HasOne(pp => pp.Product).WithMany(p => p.ProductProperties).HasForeignKey(pp => pp.ProductId);
            builder.HasOne(pp => pp.Property).WithMany(p => p.ProductProperties).HasForeignKey(pp => pp.PropertyId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(pp => pp.Option).WithMany().HasForeignKey(pp => pp.OptionId);
        }
    }
}
