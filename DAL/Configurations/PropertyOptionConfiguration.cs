using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    public class PropertyOptionConfiguration : IEntityTypeConfiguration<PropertyOption>
    {
        public void Configure(EntityTypeBuilder<PropertyOption> builder)
        {
            builder.ToTable("PropertyOption");
            builder.HasKey(po => po.Id);
            builder.HasOne(p => p.Property).WithMany(p => p.Options).HasForeignKey(p => p.PropertyId);

        }
    }
}
