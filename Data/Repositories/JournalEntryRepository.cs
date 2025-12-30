using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class JournalEntryRepository : GenericRepository<JournalEntry>, IJournalEntryRepository
    {
        public JournalEntryRepository(TheSeerDbContext context) : base(context)
        {
        }

        public JournalEntry GetById(Guid id)
        {
            return _dbSet
                .Include(j => j.Reading)
                    .ThenInclude(r => r.Spread)
                .FirstOrDefault(j => j.Id == id);
        }

        public IQueryable<JournalEntry> GetUserJournal(Guid userId) => _dbSet.Where(j => j.UserId == userId).OrderByDescending(j => j.DateWritten);
        public JournalEntry GetEntryByReading(Guid readingId) => _dbSet.FirstOrDefault(j => j.ReadingId == readingId);
        public IQueryable<JournalEntry> GetAllByUserId(Guid userId) => _dbSet.Where(je => je.UserId == userId);
        public JournalEntry GetByReadingId(Guid readingId) => _dbSet.FirstOrDefault(je => je.ReadingId == readingId);
        public JournalEntry GetByReadingIdAndUserId(Guid readingId, Guid userId)
        {
            return _dbSet.FirstOrDefault(je => je.ReadingId == readingId && je.UserId == userId);
        }
    }
}
