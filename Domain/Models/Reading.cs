using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class Reading
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int DeckId { get; set; }
        public int SpreadId { get; set; }
        public DateTime PerformedAt { get; set; }
        public string? UserMood { get; set; }
        public string Summary { get; set; } = null!;
        public string Question { get; set; } = null!;

        public User User { get; set; } = null!;
        public Deck Deck { get; set; } = null!;
        public Spread Spread { get; set; } = null!;

        public ICollection<JournalEntry> JournalEntries { get; set; } = new List<JournalEntry>();
        public ICollection<DrawnCard> DrawnCards { get; set; } = new List<DrawnCard>();
    }
}
