using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface ICardRepository : IGenericRepository<Card>
    {
        Card GetById(int id);

        IQueryable<Card> GetAllWithMeanings();
    }
}
