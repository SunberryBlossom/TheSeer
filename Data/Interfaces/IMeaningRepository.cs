using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface IMeaningRepository : IGenericRepository<Meaning>
    {
        Meaning GetById(int id);
        IQueryable<Meaning> GetMeaningsByCard(int cardId);
    }
}
