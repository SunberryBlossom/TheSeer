using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface ISpreadRepository : IGenericRepository<Spread>
    {
        Spread GetById(int id);
        IQueryable<Spread> GetSpreadsBySystem(int systemTypeId);
        Spread GetSpreadWithPositions(int id);
    }
}
