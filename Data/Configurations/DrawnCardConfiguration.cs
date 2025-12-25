using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class DrawnCardConfiguration : IEntityTypeConfiguration<DrawnCard>
    {
        public void Configure(EntityTypeBuilder<DrawnCard> builder)
        {
            // Composite key
            builder.HasKey(dc => new { dc.ReadingId, dc.SpreadPositionId });

            builder.HasIndex(dc => new { dc.ReadingId, dc.CardId }).IsUnique();

            builder.Property(dc => dc.IsReversed).IsRequired();
            builder.Property(dc => dc.DrawOrder).IsRequired();

            builder.HasOne(dc => dc.Reading).WithMany(r => r.DrawnCards).HasForeignKey(dc => dc.ReadingId).OnDelete(DeleteBehavior.Cascade).IsRequired();
            builder.HasOne(dc => dc.SpreadPosition).WithMany(sp => sp.DrawnCards).HasForeignKey(dc => dc.SpreadPositionId).IsRequired();
            builder.HasOne(dc => dc.Card).WithMany(c => c.DrawnCards).HasForeignKey(dc => dc.CardId).OnDelete(DeleteBehavior.Restrict).IsRequired();
        }
    }
}
