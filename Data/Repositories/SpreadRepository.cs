using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class SpreadRepository : GenericRepository<Spread>, ISpreadRepository
    {
        public SpreadRepository(TheSeerDbContext context) : base(context)
        {
        }

        public Spread GetById(int id) => _dbSet.Find(id);
        public IQueryable<Spread> GetSpreadsBySystem(int systemTypeId) => _dbSet.Where(s => s.SystemTypeId == systemTypeId);
        public Spread GetSpreadWithPositions(int id) => _dbSet.Include(s => s.SpreadPositions).FirstOrDefault(s => s.Id == id);

    }
}
