using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    internal class SystemType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool CanBeReversed { get; set; }
        public int DefaultCardCount { get; set; }

        public ICollection<Deck> Decks { get; set; } = new List<Deck>();
        public ICollection<Spread> Spreads { get; set; } = new List<Spread>();
    }
}
