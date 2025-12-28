using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class SpreadPositionRepository : GenericRepository<SpreadPosition>, ISpreadPositionRepository
    {
        public SpreadPositionRepository(TheSeerDbContext context) : base(context)
        {
        }

        public SpreadPosition GetById(int id) => _dbSet.Find(id);
        public IQueryable<SpreadPosition> GetPositionsBySpread(int spreadId) => _dbSet.Where(sp => sp.SpreadId == spreadId).OrderBy(sp => sp.SequenceNumber);
    }
}
