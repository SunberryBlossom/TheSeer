using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class FavoriteDeckRepository : GenericRepository<FavoriteDeck>, IFavoriteDeckRepository
    {
        public FavoriteDeckRepository(TheSeerDbContext context) : base(context)
        {
        }

        public FavoriteDeck GetById(Guid userId, int deckId) => _dbSet.Find(userId, deckId);
        public IQueryable<FavoriteDeck> GetUserFavorites(Guid userId) => _dbSet.Where(fd => fd.UserId == userId).Include(fd => fd.Deck);
        public bool IsFavorite(Guid userId, int deckId) => _dbSet.Any(fd => fd.UserId == userId && fd.DeckId == deckId);
        public IQueryable<FavoriteDeck> GetByUserId(Guid userId) => _dbSet.Where(fd => fd.UserId == userId);
    }
}
