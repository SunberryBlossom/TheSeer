using System;
using System.Collections.Generic;
using TheSeer2.Models.Enums;

namespace TheSeer2.Models
{
    internal class Reading
    {
        // ----------------------- PROPERTIES --------------------------//
        public Guid Id { get; init; }
        public Guid UserId { get; init; }
        public ReadingType Type { get; init; }
        public CardSuit CardSuit { get; init; }
        public List<Card> Cards { get; init; }
        public DateTime Timestamp { get; init; }

        // ---------------- CONSTRUCTORS -----------------------------//
        
        public Reading(Guid userId, ReadingType type, CardSuit cardSuit, List<Card> cards)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Type = type;
            CardSuit = cardSuit;
            
            if (cards == null || cards.Count == 0)
                throw new ArgumentException("A reading must have at least one card", nameof(cards));
            
            Cards = cards;
            Timestamp = DateTime.Now;
        }

        public Reading() 
        {
            Cards = new List<Card>();
        }
    }
}
