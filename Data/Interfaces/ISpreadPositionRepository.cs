using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    internal interface ISpreadPositionRepository : IGenericRepository<SpreadPosition>
    {
        SpreadPosition GetById(int id);
        IQueryable<SpreadPosition> GetPositionsBySpread(int spreadId);
    }
}
