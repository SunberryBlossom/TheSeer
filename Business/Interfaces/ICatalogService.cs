using System;
using System.Collections.Generic;
using TheSeer.Business.DTOs;

namespace TheSeer.Business.Interfaces
{
    public interface ICatalogService
    {
        IEnumerable<SystemTypeDto> GetSystemTypes();
        IEnumerable<DeckListItemDto> GetDecksBySystem(int systemTypeId, Guid userId);
        CardDetailDto GetCardDetails(int cardId);
        CardDetailDto GetDailyCard(int deckId);
        IEnumerable<DeckListItemDto> GetAllDecks();
        DeckListItemDto? GetDeckById(int id);
    }
}