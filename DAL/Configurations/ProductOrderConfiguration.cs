using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    public class ProductOrderConfiguration : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.ToTable("ProductOrder");
            builder.HasKey(po => new { po.OrderId, po.ProductId });
            builder.HasOne(po => po.Product).WithMany().HasForeignKey(po => po.ProductId);
            builder.HasOne(po => po.Order).WithMany(o => o.ProductOrders).HasForeignKey(o => o.OrderId);

        }
    }
}
