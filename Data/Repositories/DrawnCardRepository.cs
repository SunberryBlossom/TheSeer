using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class DrawnCardRepository : GenericRepository<DrawnCard>, IDrawnCardRepository
    {
        public DrawnCardRepository(TheSeerDbContext context) : base(context)
        {
        }

        public DrawnCard GetById(Guid id) => _dbSet.Find(id);
        public IQueryable<DrawnCard> GetCardsByReading(Guid readingId)
        {
            return _dbSet
                .Where(dc => dc.ReadingId == readingId)
                .Include(dc => dc.Card)
                .Include(dc => dc.SpreadPosition)
                .OrderBy(dc => dc.SpreadPosition.SequenceNumber);
        }
    }
}
