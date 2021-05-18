using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    public class CarouselConfiguration : IEntityTypeConfiguration<Carousel>
    {
        public void Configure(EntityTypeBuilder<Carousel> builder)
        {
            builder.ToTable("Carousel");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(300);
            builder.Property(c => c.ImageUrl).HasMaxLength(250);

        }
    }
}
