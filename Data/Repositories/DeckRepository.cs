using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class DeckRepository : GenericRepository<Deck>, IDeckRepository 
    {
        public DeckRepository(TheSeerDbContext context) : base(context)
        {
        }

        public Deck GetById(int id) => _dbSet.Find(id);
        public Deck GetDeckWithCards(int id) =>  _dbSet.Include(d => d.Cards).FirstOrDefault(d => d.Id == id);  
        public IQueryable<Deck> GetDecksByType(int systemTypeId) =>  _dbSet.Where(d => d.SystemTypeId == systemTypeId);
        public IQueryable<Deck> GetFavoritesByUserId(Guid userId)
        {
            return _dbSet.Where(d => d.FavoriteDecks.Any(f => f.UserId == userId));
        }

    }
}
