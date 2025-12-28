using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Business.DTOs;
using TheSeer.Domain.Models;

public interface IJournalService
{
    JournalEntryDto AddNote(Guid readingId, string content);
    IEnumerable<JournalEntryDto> GetUserJournal(Guid userId);
    bool RemoveNote(Guid journalEntryId);
    JournalEntryDto UpdateNote(JournalUpdateDto update);
}