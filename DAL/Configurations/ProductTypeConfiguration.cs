﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;


namespace DAL.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public ProductTypeConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductType");
            builder.HasKey(pt => pt.Id);
            builder.Property(pt => pt.Name).HasMaxLength(100);

        }
    }
}
