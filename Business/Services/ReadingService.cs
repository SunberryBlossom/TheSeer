using System;
using System.Collections.Generic;
using System.Linq;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Services
{
    public class ReadingService : IReadingService
    {
        private readonly IUnitOfWork _uow;

        public ReadingService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ReadingResultDto PerformReading(Guid userId, int deckId, int spreadId)
        {
            _uow.BeginTransaction();

            try
            {
                var deckCards = _uow.Cards.GetCardsByDeck(deckId).ToList();
                var positions = _uow.SpreadPositions.GetPositionsBySpread(spreadId).ToList();

                if (!deckCards.Any() || !positions.Any())
                    throw new Exception("Deck or Spread positions not found.");

                Random rng = new Random();
                int n = deckCards.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = deckCards[k];
                    deckCards[k] = deckCards[n];
                    deckCards[n] = value;
                }

                var reading = new Reading
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    DeckId = deckId,
                    SpreadId = spreadId,
                    PerformedAt = DateTime.Now,
                    DrawnCards = new List<DrawnCard>()
                };

                for (int i = 0; i < positions.Count; i++)
                {
                    var drawnCard = new DrawnCard
                    {
                        ReadingId = reading.Id,
                        SpreadPositionId = positions[i].Id,
                        CardId = deckCards[i].Id,
                        IsReversed = rng.Next(0, 2) == 1
                    };

                    reading.DrawnCards.Add(drawnCard);
                }

                _uow.Readings.Add(reading);
                _uow.Save();
                _uow.Commit();

                return GetReadingDetails(reading.Id);
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                throw new Exception("Something went wrong whilst creating the reading", ex);
            }
        }

        public ReadingResultDto GetReadingDetails(Guid readingId)
        {
            var r = _uow.Readings.GetFullReadingDetails(readingId);
            if (r == null) return null;

            return new ReadingResultDto
            {
                ReadingId = r.Id,
                PerformedAt = r.PerformedAt,
                SpreadName = r.Spread.Name,
                DrawnCards = r.DrawnCards.Select(dc =>
                {
                    var specificMeaning = dc.Card.Meanings
                        .FirstOrDefault(m => m.DeckId == r.DeckId && m.IsReversed == dc.IsReversed);

                    return new DrawnCardDto
                    {
                        CardName = dc.Card.Name,
                        PositionName = dc.SpreadPosition.Label,
                        PositionDescription = dc.SpreadPosition.Description,
                        IsReversed = dc.IsReversed,
                        MeaningText = specificMeaning?.Content ?? "No specific meaning found for this card in this deck."
                    };
                }).ToList()
            };
        }

        public IEnumerable<ReadingHistoryDto> GetUserHistory(Guid userId)
        {
            var readings = _uow.Readings.GetHistoryByUserId(userId);

            return readings.Select(r => new ReadingHistoryDto
            {
                ReadingId = r.Id,
                PerformedAt = r.PerformedAt,
                SpreadName = r.Spread.Name,
                Summary = $"{r.DrawnCards.Count} cards drawn."
            });
        }
    }
}