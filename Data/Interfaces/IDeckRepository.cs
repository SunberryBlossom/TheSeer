using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    internal interface IDeckRepository : IGenericRepository<Deck>
    {
        Deck GetById(int id);
        Deck GetDeckWithCards(int id);
        IQueryable<Deck> GetDecksByType(int systemTypeId);
    }
}
