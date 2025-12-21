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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TheSeerDbContext).Assembly);
        }
    }
}
