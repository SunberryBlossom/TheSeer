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
    }
}
