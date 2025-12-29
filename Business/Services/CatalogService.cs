using System;
using System.Collections.Generic;
using System.Linq;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Data;
using TheSeer.Data.Interfaces;

namespace TheSeer.Business.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly IUnitOfWork _uow;

        public CatalogService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<DeckListItemDto> GetAllDecks()
        {
            var decks = _uow.Decks.GetAllWithCards();

            return decks.Select(d => new DeckListItemDto
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                CardCount = d.Cards.Count,
                SystemName = d.SystemType.Name
            }).ToList();
        }

        public DeckListItemDto? GetDeckById(int id)
        {
            var deck = _uow.Decks.GetById(id);
            if (deck == null) return null;

            return new DeckListItemDto
            {
                Id = deck.Id,
                Name = deck.Name,
                Description = deck.Description,
                Cards = deck.Cards.Select(c => new CardDetailDto
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList()
            };
        }

        public IEnumerable<SystemTypeDto> GetSystemTypes()
        {
            return _uow.SystemTypes.GetAll().Select(s => new SystemTypeDto
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description
            });
        }

        public IEnumerable<DeckListItemDto> GetDecksBySystem(int systemTypeId, Guid userId)
        {
            var decks = _uow.Decks.GetDecksByType(systemTypeId);

            var favorites = _uow.FavoriteDecks.GetByUserId(userId)
                                .Select(f => f.DeckId)
                                .ToList();

            return decks.Select(d => new DeckListItemDto
            {
                Id = d.Id,
                Name = d.Name,
                SystemName = d.SystemType.Name,
                IsFavorite = favorites.Contains(d.Id)
            });
        }

        public CardDetailDto GetCardDetails(int cardId)
        {
            var card = _uow.Cards.GetCardWithMeanings(cardId);
            if (card == null) return null;

            return new CardDetailDto
            {
                Id = card.Id,
                Name = card.Name,
                Suit = card.SuitOrGroup,
                Meanings = card.Meanings.Select(m => new MeaningDto
                {
                    Category = m.Category,
                    Content = m.Content,
                    KeyWords = m.KeyWords,
                    IsReversed = m.IsReversed
                }).ToList()
            };
        }

        public CardDetailDto GetDailyCard(int deckId)
        {
            var cards = _uow.Cards.GetCardsByDeck(deckId).ToList();
            if (!cards.Any()) return null;

            var random = new Random();
            var randomCard = cards[random.Next(cards.Count)];

            return GetCardDetails(randomCard.Id);
        }
    }
}