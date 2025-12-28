using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class ReadingRepository : GenericRepository<Reading>, IReadingRepository
    {
        public ReadingRepository(TheSeerDbContext context) : base(context)
        {
        }

        public Reading GetById(Guid id) => _dbSet.Find(id);

        public Reading GetFullReadingDetails(Guid id)
        {
            return _dbSet
                .Include(r => r.Spread)
                .Include(r => r.DrawnCards)
                .ThenInclude(dc => dc.Card)
                .Include(r => r.DrawnCards)
                .ThenInclude(dc => dc.SpreadPosition)
                .FirstOrDefault(r => r.Id == id);
        }

        public IQueryable<Reading> GetHistoryByUserId(Guid userId)
        {
            return _dbSet
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.PerformedAt);
        }
    }
}
