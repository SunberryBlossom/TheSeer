using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class ReadingConfiguration : IEntityTypeConfiguration<Reading>
    {
        public void Configure(EntityTypeBuilder<Reading> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.UserMood).HasMaxLength(100);
            builder.Property(r => r.Summary).IsRequired();

            builder.HasOne(r => r.User).WithMany(u => u.Readings).HasForeignKey(r => r.UserId).IsRequired();
            builder.HasOne(r => r.Deck).WithMany(d => d.Readings).HasForeignKey(r => r.DeckId).IsRequired();
            builder.HasOne(r => r.Spread).WithMany(s => s.Readings).HasForeignKey(r => r.SpreadId).OnDelete(DeleteBehavior.Restrict).IsRequired();

            builder.HasMany(r => r.JournalEntries).WithOne(je => je.Reading).HasForeignKey(je => je.ReadingId);
            builder.HasMany(r => r.DrawnCards).WithOne(dc => dc.Reading).HasForeignKey(dc => dc.ReadingId);
        }
    }
}
