using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
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

            SeedStaticData(modelBuilder);

            SeedFromJson<Card>(modelBuilder, "TheSeerCards.json");
            SeedFromJson<Meaning>(modelBuilder, "TheSeerCardsMeanings.json");
            SeedFromJson<Spread>(modelBuilder, "TheSeerOriginalDeckSpreads.json");
            SeedFromJson<SpreadPosition>(modelBuilder, "TheSeerOriginalSpreadPositions.json");

            SeedFromJson<Card>(modelBuilder, "ElderFutharkRunes.json");
            SeedFromJson<Meaning>(modelBuilder, "ElderFutharkRuneMeanings.json");
            SeedFromJson<Spread>(modelBuilder, "ElderFutharkSpreads.json");
            SeedFromJson<SpreadPosition>(modelBuilder, "ElderFutharkSpreadPositions.json");

            SeedFromJson<Card>(modelBuilder, "TheSeerOracleCards.json");
            SeedFromJson<Meaning>(modelBuilder, "TheSeerOracleCardsMeanings.json");
            SeedFromJson<Spread>(modelBuilder, "TheSeerOracleDeckSpreads.json");
            SeedFromJson<SpreadPosition>(modelBuilder, "TheSeerOracleSpreadPositions.json");
        }

        private void SeedFromJson<T>(ModelBuilder modelBuilder, string fileName) where T : class
        {
            string folderName = "SeedData";
            string path = Path.Combine(AppContext.BaseDirectory, folderName, fileName);

            if (!File.Exists(path))
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), folderName, fileName);
            }

            // OM FILEN FORTFARANDE INTE FINNS - STOPPA ALLT OCH BERÄTTA VARFÖR
            if (!File.Exists(path))
            {
                var errorPath = Path.GetFullPath(path);
                throw new Exception($"STOPP! Migrationen hittar inte filen: {fileName}. Den letade här: {errorPath}");
            }

            var json = File.ReadAllText(path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<List<T>>(json, options);

            if (data != null && data.Any())
            {
                modelBuilder.Entity<T>().HasData(data);
            }
        }

        private void SeedStaticData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemType>().HasData
    (
        new SystemType
        {
            Id = 1,
            Name = "Tarot",
            CanBeReversed = true,
            DefaultCardCount = 78,
            Description = "The classical system for introspection, guidance and spirital development. Usually has 78 cards, always divided into the major and minor arcana."
        },
        new SystemType
        {
            Id = 2,
            Name = "Runes",
            CanBeReversed = true,
            DefaultCardCount = 24,
            Description = "An old norse system built upon the old futhark of 24 runes. Each rune symbolize natural powers and gods or godesses. Used to interpret hidden energies and bigger happenings in life."
        },
        new SystemType
        {
            Id = 3,
            Name = "Oracle",
            CanBeReversed = false,
            DefaultCardCount = 44,
            Description = "A free and intuitive system for guidance. Not as strict as the Tarot system. Usually have unique themes, and can be flexible regarding card count."
        }
    );

            modelBuilder.Entity<Deck>().HasData
                (
                    new Deck
                    {
                        Id = 1,
                        Name = "The Seer's deck",
                        SystemTypeId = 1,
                        Creator = "Elvira Mariesdotter",
                        IsLocked = false,
                        Description = "The deck the seer herself carved out of the sandstone in her lands. Carries specific suits and meanings. Can create somewhat harsh readings, but always true and with good intent.",
                        AssetFolder = " ",
                        CardBackImage = " ",
                        DateOfPublish = new DateOnly(2025, 12, 25)
                    },
                    new Deck
                    {
                        Id = 2,
                        Name = "Lord of the Rings Tarot",
                        SystemTypeId = 1,
                        Creator = "Casey Gilly",
                        IsLocked = false,
                        Description = "A Lord of the Rings inspired tarot deck, replacing the pentacle suit with rings instead. All Major arcana and clothed cards are named after characters from the Realm of J.R.R. Tolkien. Illustrations by Tomas Hijo.",
                        AssetFolder = " ",
                        CardBackImage = " ",
                        DateOfPublish = new DateOnly(2022, 08, 28)
                    },
                    new Deck
                    {
                        Id = 3,
                        Name = "The oracles of the dunes",
                        SystemTypeId = 3,
                        Creator = "Elvira Mariesdotter",
                        IsLocked = false,
                        Description = "Oracle cards represented by the spirits of the dunes in the land of the Seer. Includes 44 cards meant to guide you when doubt is clouding your vision.",
                        AssetFolder = " ",
                        CardBackImage = " ",
                        DateOfPublish = new DateOnly(2025, 12, 26)
                    },
                    new Deck
                    {
                        Id = 4,
                        Name = "Elder futhark runes",
                        SystemTypeId = 2,
                        Creator = "Elvira Mariesdotter",
                        IsLocked = false,
                        Description = "A set of 24 old futhark runes. Standard rune set for fortune telling used by the ancient norse.",
                        AssetFolder = " ",
                        CardBackImage = " ",
                        DateOfPublish = new DateOnly(2025, 12, 26)
                    }
                );
        }
    }
}
