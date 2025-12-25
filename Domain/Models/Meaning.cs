using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class Meaning
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int DeckId { get; set; }
        public string Category { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string? KeyWords { get; set; }
        public bool IsReversed { get; set; }

        public Card Card { get; set; } = null!;
        public Deck Deck { get; set; } = null!;
    }
}
