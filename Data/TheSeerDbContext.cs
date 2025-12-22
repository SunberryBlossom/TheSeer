using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data
{
    internal class TheSeerDbContext : DbContext
    {
        public TheSeerDbContext(DbContextOptions<TheSeerDbContext> options) : base(options) { }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Reading> Readings { get; set; }
        public DbSet<Spread> Spreads { get; set; }
        public DbSet<SpreadPosition> SpreadPositions { get; set; }
        public DbSet<DrawnCard> DrawnCards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Meaning> Meanings { get; set; }
        public DbSet<SystemType> SystemTypes { get; set; }
        public DbSet<FavoriteDeck> favoriteDecks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TheSeerDbContext).Assembly);
        }
    }
}
