using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface ICardRepository : IGenericRepository<Card>
    {
        Card GetById(int id);

        IQueryable<Card> GetAllWithMeanings();
        IQueryable<Card> GetCardsByDeck(int deckId);
        Card GetCardWithMeanings(int cardId);
    }
}
