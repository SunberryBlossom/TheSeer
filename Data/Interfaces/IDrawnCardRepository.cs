using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    internal interface IDrawnCardRepository : IGenericRepository<DrawnCard>
    {
        DrawnCard GetById(Guid id);
        IQueryable<DrawnCard> GetCardsByReading(Guid readingId);
    }
}
