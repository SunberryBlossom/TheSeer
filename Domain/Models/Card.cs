using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Name { get; set; } = null!;
        public int Value { get; set; }
        public string SuitOrGroup { get; set; } = null!;
        public string ImageKey { get; set; } = null!;
        public string Description { get; set; } = null!;

        public Deck Deck { get; set; } = null!;
        public ICollection<DrawnCard> DrawnCards { get; set; } = new List<DrawnCard>();
        public ICollection<Meaning> Meanings { get; set; } = new List<Meaning>();

    }
}
