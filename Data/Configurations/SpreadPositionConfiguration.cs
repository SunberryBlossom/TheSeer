using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class SpreadPositionConfiguration : IEntityTypeConfiguration<SpreadPosition>
    {
        public void Configure(EntityTypeBuilder<SpreadPosition> builder)
        {
            builder.HasKey(sp => sp.Id);

            builder.Property(sp => sp.Label).HasMaxLength(255);
            builder.Property(sp => sp.Description).HasMaxLength(500).IsRequired();
            builder.Property(sp => sp.SequenceNumber).IsRequired();

            builder.HasOne(sp => sp.Spread).WithMany(s => s.SpreadPositions).HasForeignKey(sp => sp.SpreadId).OnDelete(DeleteBehavior.Cascade).IsRequired();

            builder.HasMany(sp => sp.DrawnCards).WithOne(dc => dc.SpreadPosition).HasForeignKey(dc => dc.SpreadPositionId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
