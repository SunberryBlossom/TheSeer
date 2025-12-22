using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Domain.Models
{
    internal class FavoriteDeck
    {
        public Guid UserId { get; set; }
        public int DeckId { get; set; }
        public string? Nickname { get; set; }
        public DateTime AddedAt { get; set; }

        public Deck Deck { get; set; } = null!;
        public User User { get; set; } = null!;

    }
}
