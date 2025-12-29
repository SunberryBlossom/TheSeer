using TheSeer.Business.DTOs;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Interfaces
{
    public interface IReadingService
    {
        ReadingResultDto GetReadingDetails(Guid readingId, bool canBeReversed);
        IEnumerable<ReadingHistoryDto> GetUserHistory(Guid userId);
        public ReadingResultDto PerformReading(Guid userId, int deckId, int spreadId, string question);
    }
}