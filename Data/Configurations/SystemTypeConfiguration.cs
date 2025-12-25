using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    internal class SystemTypeConfiguration : IEntityTypeConfiguration<SystemType>
    {
        public void Configure(EntityTypeBuilder<SystemType> builder)
        {
            builder.HasKey(st => st.Id);

            builder.Property(st => st.Name).HasMaxLength(150).IsRequired();
            builder.Property(st => st.Description).HasMaxLength(1000).IsRequired();
            builder.Property(st => st.CanBeReversed).IsRequired();
            builder.Property(st => st.DefaultCardCount).IsRequired();

            builder.HasMany(st => st.Decks).WithOne(d => d.SystemType).HasForeignKey(d => d.SystemTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(st => st.Spreads).WithOne(s => s.SystemType).HasForeignKey(s => s.SystemTypeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
