using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string HashedPassword { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string? DisplayName { get; set; }
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime LastLoginAt { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; } // Not yet implemented! 
        public string Role { get; set; } = null!;

        public ICollection<Reading> Readings { get; set; } = new List<Reading>();
        public ICollection<JournalEntry> JournalEntries { get; set; } = new List<JournalEntry>();
        public ICollection<FavoriteDeck> FavoriteDecks { get; set; } = new List<FavoriteDeck>();
    }
}
