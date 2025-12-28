using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    internal interface IJournalEntryRepository : IGenericRepository<JournalEntry>
    {
        JournalEntry GetById(Guid id);
        IQueryable<JournalEntry> GetUserJournal(Guid userId);
        JournalEntry GetEntryByReading(Guid readingId);
    }
}
