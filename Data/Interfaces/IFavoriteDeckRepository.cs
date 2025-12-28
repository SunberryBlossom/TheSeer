using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    internal interface IFavoriteDeckRepository : IGenericRepository<FavoriteDeck>
    {
        FavoriteDeck GetById(Guid userId, int deckId);
        IQueryable<FavoriteDeck> GetUserFavorites(Guid userId);
        bool IsFavorite(Guid userId, int deckId);
    }
}
