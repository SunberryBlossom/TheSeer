using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface IJournalEntryRepository : IGenericRepository<JournalEntry>
    {
        JournalEntry GetById(Guid id);
        IQueryable<JournalEntry> GetUserJournal(Guid userId);
        JournalEntry GetEntryByReading(Guid readingId);
        JournalEntry GetByReadingId(Guid readingId);
        IQueryable<JournalEntry> GetAllByUserId(Guid userId);
    }
}
