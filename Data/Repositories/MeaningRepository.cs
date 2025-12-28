using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class MeaningRepository : GenericRepository<Meaning>, IMeaningRepository
    {
        public MeaningRepository(TheSeerDbContext context) : base(context)
        {
        }

        public Meaning GetById(int id) => _dbSet.Find(id);

        public IQueryable<Meaning> GetMeaningsByCard(int cardId) => _dbSet.Where(m => m.CardId == cardId);
    }
}
