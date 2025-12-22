using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class MeaningConfiguration : IEntityTypeConfiguration<Meaning>
    {
        public void Configure(EntityTypeBuilder<Meaning> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Category).HasMaxLength(100).IsRequired();
            builder.Property(m => m.Content).IsRequired();
            builder.Property(m => m.KeyWords).HasMaxLength(100).IsRequired();
            builder.Property(m => m.IsReversed).IsRequired();

            builder.HasOne(m => m.Card).WithMany(c => c.Meanings).HasForeignKey(m => m.CardId).IsRequired();
            builder.HasOne(m => m.Deck).WithMany(d => d.Meanings).HasForeignKey(m => m.DeckId);
        }
    }
}
