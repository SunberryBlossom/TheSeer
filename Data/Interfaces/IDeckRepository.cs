using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface IDeckRepository : IGenericRepository<Deck>
    {
        Deck GetById(int id);
        Deck GetDeckWithCards(int id);
        IQueryable<Deck> GetDecksByType(int systemTypeId);
        IQueryable<Deck> GetFavoritesByUserId(Guid userId);
        public IEnumerable<Deck> GetAllWithCards();
    }
}
