using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class FavoriteDeckConfiguration : IEntityTypeConfiguration<FavoriteDeck>
    {
        public void Configure(EntityTypeBuilder<FavoriteDeck> builder)
        {
            builder.HasKey(fd => new { fd.UserId, fd.DeckId });

            builder.Property(fd => fd.Nickname).HasMaxLength(100);
            builder.Property(fd => fd.AddedAt).IsRequired();

            builder.HasOne(fd => fd.User).WithMany(u => u.FavoriteDecks).HasForeignKey(fd => fd.UserId).IsRequired();
            builder.HasOne(fd => fd.Deck).WithMany(d => d.FavoriteDecks).HasForeignKey(fd => fd.DeckId).IsRequired();
        }
    }
}
