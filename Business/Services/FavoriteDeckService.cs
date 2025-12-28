using System;
using System.Collections.Generic;
using System.Linq;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Services
{
    public class FavoriteDeckService : IFavoriteDeckService
    {
        private readonly IUnitOfWork _uow;

        public FavoriteDeckService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void ToggleFavorite(Guid userId, int deckId)
        {
            // Vi kollar om kopplingen redan finns
            var existing = _uow.FavoriteDecks.GetById(userId, deckId);

            if (existing != null)
            {
                _uow.FavoriteDecks.Remove(existing);
            }
            else
            {
                var favorite = new FavoriteDeck
                {
                    UserId = userId,
                    DeckId = deckId
                };
                _uow.FavoriteDecks.Add(favorite);
            }

            _uow.Save();
        }

        public IEnumerable<DeckListItemDto> GetFavorites(Guid userId)
        {
            var favoriteDecks = _uow.Decks.GetFavoritesByUserId(userId).ToList();

            return favoriteDecks.Select(d => new DeckListItemDto
            {
                Id = d.Id,
                Name = d.Name,
                SystemName = d.SystemType?.Name ?? "Unknown",
                IsFavorite = true
            });
        }

        public bool IsFavorite(Guid userId, int deckId)
        {
            var favorite = _uow.FavoriteDecks.GetById(userId, deckId);
            return favorite != null;
        }
    }
}