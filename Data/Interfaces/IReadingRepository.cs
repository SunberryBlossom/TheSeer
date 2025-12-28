using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface IReadingRepository : IGenericRepository<Reading>
    {
        Reading GetById(Guid id);
        Reading GetFullReadingDetails(Guid id);
        IQueryable<Reading> GetHistoryByUserId(Guid userId);
    }
}
