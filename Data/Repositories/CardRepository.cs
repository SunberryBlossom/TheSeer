using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    public class CardRepository : GenericRepository<Card>, ICardRepository
    {

        public CardRepository(TheSeerDbContext context) : base(context)
        {

        }

        public Card GetById(int id) => _dbSet.Find(id);
        public IQueryable<Card> GetAllWithMeanings() => _dbSet.Include(c => c.Meanings);
        public IQueryable<Card> GetCardsByDeck(int deckId) => _dbSet.Where(c => c.DeckId == deckId);
        public Card GetCardWithMeanings(int cardId) => _dbSet.Include(c => c.Meanings).FirstOrDefault(c => c.Id == cardId);
    }
}
