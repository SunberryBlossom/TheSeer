using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class DeckConfiguration : IEntityTypeConfiguration<Deck>
    {
        public void Configure(EntityTypeBuilder<Deck> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name).HasMaxLength(200).IsRequired();
            builder.Property(d => d.Creator).HasMaxLength(200);
            builder.Property(d => d.AssetFolder).HasMaxLength(255).IsRequired();
            builder.Property(d => d.CardBackImage).HasMaxLength(255).IsRequired();

            builder.HasOne(d => d.SystemType).WithMany(st => st.Decks).HasForeignKey(d => d.SystemTypeId).OnDelete(DeleteBehavior.Restrict).IsRequired();

            builder.HasMany(d => d.Cards).WithOne(c => c.Deck).HasForeignKey(c => c.DeckId);
            builder.HasMany(d => d.Readings).WithOne(r => r.Deck).HasForeignKey(r => r.DeckId);
            builder.HasMany(d => d.Meanings).WithOne(m => m.Deck).HasForeignKey(m => m.DeckId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(d => d.FavoriteDecks).WithOne(fd => fd.Deck).HasForeignKey(fd => fd.DeckId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
