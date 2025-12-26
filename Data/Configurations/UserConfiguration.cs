using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.HashedPassword).IsRequired();
            builder.Property(u => u.Username).HasMaxLength(60).IsRequired();
            builder.Property(u => u.DisplayName).HasMaxLength(60);
            builder.Property(u => u.Email).HasMaxLength(255).IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.Role).IsRequired();

            builder.HasMany(u => u.FavoriteDecks).WithOne(fd => fd.User).HasForeignKey(fd => fd.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.JournalEntries).WithOne(je => je.User).HasForeignKey(je => je.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.Readings).WithOne(r => r.User).HasForeignKey(r => r.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
