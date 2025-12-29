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

        public ReadingResultDto PerformReading(Guid userId, int deckId, int spreadId, string question)
        {
            _uow.BeginTransaction();

            try
            {
                var deck = _uow.Decks.GetById(deckId);
                if (deck == null)
                    throw new Exception("Deck not found.");

                var canBeReversed = deck.SystemType?.CanBeReversed ?? false;

                var deckCards = _uow.Cards.GetCardsByDeck(deckId).ToList();
                var positions = _uow.SpreadPositions.GetPositionsBySpread(spreadId).ToList();

                if (!deckCards.Any() || !positions.Any())
                    throw new Exception("Deck or Spread positions not found.");

                Random rng = new Random();
                for (int n = deckCards.Count - 1; n > 0; n--)
                {
                    int k = rng.Next(n + 1);
                    var temp = deckCards[k];
                    deckCards[k] = deckCards[n];
                    deckCards[n] = temp;
                }

                var reading = new Reading
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    DeckId = deckId,
                    SpreadId = spreadId,
                    PerformedAt = DateTime.Now,
                    DrawnCards = new List<DrawnCard>(),
                    Summary = $"Reading performed with {Math.Min(positions.Count, deckCards.Count)} cards drawn for spread '{_uow.Spreads.GetById(spreadId)?.Name ?? "Unknown"}'.",
                    Question = question
                };

                for (int i = 0; i < positions.Count; i++)
                {
                    if (i >= deckCards.Count) break;

                    var card = deckCards[i];
                    bool isReversed = false;

                    if (deck.SystemType?.Name?.Equals("Runes", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        // Check if this rune/card has any reversed meanings
                        bool runeHasReversedMeaning = card.Meanings?.Any(m => m.IsReversed) == true;
                        isReversed = runeHasReversedMeaning ? (rng.Next(0, 2) == 1) : false;
                    }
                    else if (canBeReversed)
                    {
                        isReversed = rng.Next(0, 2) == 1;
                    }

                    var drawnCard = new DrawnCard
                    {
                        ReadingId = reading.Id,
                        SpreadPositionId = positions[i].Id,
                        CardId = card.Id,
                        IsReversed = isReversed,
                        DrawOrder = i + 1
                    };

                    reading.DrawnCards.Add(drawnCard);
                }

                _uow.Readings.Add(reading);
                _uow.Save();
                _uow.Commit();

                return GetReadingDetails(reading.Id, canBeReversed);
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                throw new Exception($"Something went wrong whilst creating the reading: {ex.Message}", ex);
            }
        }

        public ReadingResultDto GetReadingDetails(Guid readingId, bool canBeReversed)
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
                    return new DrawnCardDto
                    {
                        Card = dc.Card.Name,
                        SpreadPositionId = dc.SpreadPositionId,
                        SpreadPosition = dc.SpreadPosition.Label,
                        SpreadPositionDescription = dc.SpreadPosition.Description,
                        DrawOrder = dc.DrawOrder,
                        IsReversed = dc.IsReversed,
                        MeaningText = canBeReversed
                            ? dc.Card.Meanings.Where(m => m.IsReversed == dc.IsReversed).ToList()
                            : dc.Card.Meanings.Where(m => !m.IsReversed).ToList()
                    };
                }).ToList(),
                Question = r.Question
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