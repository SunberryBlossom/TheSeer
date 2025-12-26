using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class SpreadConfiguration : IEntityTypeConfiguration<Spread>
    {
        public void Configure(EntityTypeBuilder<Spread> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name).HasMaxLength(255).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(1000).IsRequired();
            builder.Property(s => s.ImageOverlay).HasMaxLength(255);

            builder.HasOne(s => s.SystemType).WithMany(st => st.Spreads).HasForeignKey(s => s.SystemTypeId).IsRequired();

            builder.HasMany(s => s.Readings).WithOne(r => r.Spread).HasForeignKey(r => r.SpreadId);
            builder.HasMany(s => s.SpreadPositions).WithOne(sp => sp.Spread).HasForeignKey(sp => sp.SpreadId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
