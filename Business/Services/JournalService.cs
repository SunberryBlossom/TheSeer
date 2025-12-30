using System;
using System.Collections.Generic;
using System.Linq;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Services
{
    public class JournalService : IJournalService
    {
        private readonly IUnitOfWork _uow;

        public JournalService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<ReadingHistoryDto> GetUserReadings(Guid userId)
        {
            return _uow.Readings.GetHistoryByUserId(userId)
                .Select(r => new ReadingHistoryDto
                {
                    ReadingId = r.Id,
                    PerformedAt = r.PerformedAt,
                    SpreadName = r.Spread.Name,
                    Summary = $"{r.DrawnCards.Count} cards drawn."
                });
        }

        public JournalEntryDto? AddNote(Guid readingId, Guid userId, string header, string content)
        {
            if (string.IsNullOrWhiteSpace(header))
                throw new ArgumentException("Journal entry header cannot be empty.", nameof(header));
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Journal entry content cannot be empty.", nameof(content));

            if (_uow.JournalEntries.GetByReadingIdAndUserId(readingId, userId) != null)
                throw new InvalidOperationException("A journal entry already exists for this reading and user. Please update the existing entry.");

            var entry = new JournalEntry
            {
                Id = Guid.NewGuid(),
                ReadingId = readingId,
                UserId = userId,
                Header = header,
                Content = content,
                DateWritten = DateTime.Now
            };

            _uow.JournalEntries.Add(entry);
            _uow.Save();

            return GetEntryById(entry.Id);
        }

        public IEnumerable<JournalEntryDto> GetUserJournal(Guid userId)
        {
            var entries = _uow.JournalEntries.GetAllByUserId(userId);

            return entries.Select(e => new JournalEntryDto
            {
                Id = e.Id,
                ReadingId = e.ReadingId,
                UserId = e.UserId,
                ReadingDate = e.Reading.PerformedAt,
                SpreadName = e.Reading.Spread.Name,
                Header = e.Header,                
                TextContent = e.Content,
                CreatedAt = e.DateWritten,
                UpdatedAt = e.UpdatedAt
            });
        }

        public JournalEntryDto UpdateNote(JournalUpdateDto updateDto)
        {
            if (string.IsNullOrWhiteSpace(updateDto.NewTextContent))
                throw new ArgumentException("New content cannot be empty.", nameof(updateDto.NewTextContent));

            var entry = _uow.JournalEntries.GetById(updateDto.Id);
            if (entry == null)
                throw new KeyNotFoundException($"Entry {updateDto.Id} not found.");

            entry.Content = updateDto.NewTextContent;
            if (!string.IsNullOrWhiteSpace(updateDto.NewHeader))
                entry.Header = updateDto.NewHeader;
            entry.UpdatedAt = DateTime.Now;
            _uow.Save();

            return GetEntryById(entry.Id);
        }

        public bool RemoveNote(Guid journalEntryId)
        {
            var entry = _uow.JournalEntries.GetById(journalEntryId);
            if (entry == null) return false;

            _uow.JournalEntries.Remove(entry);
            _uow.Save();
            return true;
        }

        private JournalEntryDto GetEntryById(Guid id)
        {
            var e = _uow.JournalEntries.GetById(id);
            if (e == null) return null;

            return new JournalEntryDto
            {
                Id = e.Id,
                ReadingId = e.ReadingId,
                UserId = e.UserId,
                ReadingDate = e.Reading.PerformedAt,
                SpreadName = e.Reading.Spread.Name,
                Header = e.Header,               
                TextContent = e.Content,
                CreatedAt = e.DateWritten,
                UpdatedAt = e.UpdatedAt     
            };
        }
    }
}