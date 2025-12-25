using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).HasMaxLength(200).IsRequired();
            builder.Property(c => c.SuitOrGroup).HasMaxLength(100).IsRequired();
            builder.Property(c => c.ImageKey).HasMaxLength(255);
            builder.Property(c => c.Value).IsRequired();

            builder.HasOne(c => c.Deck).WithMany(d => d.Cards).HasForeignKey(c => c.DeckId).OnDelete(DeleteBehavior.Cascade).IsRequired();

            builder.HasMany(c => c.DrawnCards).WithOne(dc => dc.Card).HasForeignKey(dc => dc.CardId);
            builder.HasMany(c => c.Meanings).WithOne(m => m.Card).HasForeignKey(m => m.CardId);
        }
    }
}
