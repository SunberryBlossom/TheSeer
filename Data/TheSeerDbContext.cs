using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using TheSeer.Domain.Models;

namespace TheSeer.Data
{
    public class TheSeerDbContext : DbContext, IInfrastructure<IServiceProvider>, IDbContextDependencies, IDbSetCache, IDbContextPoolable, IResettableService, IDisposable, IAsyncDisposable
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
        public DbSet<FavoriteDeck> FavoriteDecks { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TheSeerDbContext).Assembly);

            modelBuilder.Entity<SystemType>().HasData
                (
                    new SystemType { Id = 1, Name = "Tarot", CanBeReversed = true, DefaultCardCount = 78, Description = "The classical system for introspection, guidance and spirital development. Usually has 78 cards, always divided into the major and minor arcana." },
                    new SystemType { Id = 2, Name = "Runes", CanBeReversed = true, DefaultCardCount = 24, Description = "An old norse system built upon the old futhark of 24 runes. Each rune symbolize natural powers and gods or godesses. Used to interpret hidden energies and bigger happenings in life." },
                    new SystemType { Id = 3, Name = "Oracle", CanBeReversed = false, DefaultCardCount = 44, Description = "A free and intuitive system for guidance. Not as strict as the Tarot system. Usually have unique themes, and can be flexible regarding card count." }
                );

            modelBuilder.Entity<SystemType>().HasData
                (
                    new Deck {Id = 1, Name = "The Seer's own deck", SystemTypeId = 1, Creator = "Elvira Mariesdotter", IsLocked = false, Description = "The deck the seer herself carved out of the sandstone in her lands. Carries specific suits and meanings. Can create somewhat harsh readings, but always true and with good intent." }
                );
        }
    }
}
