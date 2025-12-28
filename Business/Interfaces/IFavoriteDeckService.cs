using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Business.DTOs;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Interfaces
{
    public interface IFavoriteDeckService
    {
        void ToggleFavorite(Guid userId, int deckId);
        IEnumerable<DeckListItemDto> GetFavorites(Guid userId);
        bool IsFavorite(Guid userId, int deckId);
    }
}