using TheSeer.Business.DTOs;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Interfaces
{
    public interface IReadingService
    {
        ReadingResultDto PerformReading(Guid userId, int deckId, int spreadId);
        ReadingResultDto GetReadingDetails(Guid readingId);
        IEnumerable<ReadingHistoryDto> GetUserHistory(Guid userId);
    }
}