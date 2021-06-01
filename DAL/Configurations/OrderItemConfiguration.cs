using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem");
            builder.HasKey(oi => new { oi.OrderId, oi.ProductId });
            builder.HasOne(oi => oi.Product).WithMany().HasForeignKey(oi => oi.ProductId);
            builder.HasOne(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(o => o.OrderId);

        }
    }
}
