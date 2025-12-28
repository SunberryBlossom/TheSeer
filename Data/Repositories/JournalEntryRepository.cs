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

        public JournalEntry GetById(Guid id) => _dbSet.Find(id);
        public IQueryable<JournalEntry> GetUserJournal(Guid userId) => _dbSet.Where(j => j.UserId == userId).OrderByDescending(j => j.DateWritten);
        public JournalEntry GetEntryByReading(Guid readingId) =>_dbSet.FirstOrDefault(j => j.ReadingId == readingId);
    }
}
