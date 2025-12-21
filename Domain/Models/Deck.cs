using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public int SystemTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Creator { get; set; }
        public string Description { get; set; } = null!;
        public DateOnly DateOfPublish { get; set; }
        public string AssetFolder { get; set; } = null!;
        public string CardBackImage { get; set; } = null!;
        public bool IsLocked { get; set; }

        public virtual SystemType SystemType { get; set; } = null!;
        public virtual ICollection<Reading> Readings { get; set; } = new List<Reading>();
        public  virtual ICollection<FavoriteDeck> FavoriteDecks { get; set; } = new List<FavoriteDeck>();
        public virtual ICollection<Meaning> Meanings { get; set; } = new List<Meaning>();
        public virtual ICollection<Card> Cards { get; set; } = new List<Card>();


    }
}
