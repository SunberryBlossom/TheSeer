using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class JournalEntryConfiguration : IEntityTypeConfiguration<JournalEntry>
    {
        public void Configure (EntityTypeBuilder<JournalEntry> builder)
        {
            builder.HasKey(je => je.Id);

            builder.Property(je => je.DateWritten).IsRequired();
            builder.Property(je => je.Header).HasMaxLength(150).IsRequired();
            builder.Property(je => je.Content).IsRequired();

            builder.HasOne(je => je.Reading).WithMany(r => r.JournalEntries).HasForeignKey(je => je.ReadingId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(je => je.User).WithMany(u => u.JournalEntries).HasForeignKey(je => je.UserId).OnDelete(DeleteBehavior.NoAction).IsRequired();
        }

    }
}
