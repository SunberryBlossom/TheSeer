using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public int SystemTypeId { get; set; }
        public string Name { get; set; }
        public string? Creator { get; set; }
        public string Description { get; set; }
        public DateOnly DateOfPublish { get; set; }
        public string AssetFolder { get; set; }
        public string CardBackImage { get; set; }
        public bool IsLocked { get; set; }

        public virtual SystemType SystemType { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
        public  virtual ICollection<FavoriteDeck> FavoriteDecks { get; set; }
        public virtual ICollection<Meaning> Meanings { get; set; }
        public virtual ICollection<Card> Cards { get; set; }


    }
}
