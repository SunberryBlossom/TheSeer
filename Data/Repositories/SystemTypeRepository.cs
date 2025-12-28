using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class SystemTypeRepository : GenericRepository<SystemType>, ISystemTypeRepository
    {
        public SystemTypeRepository(TheSeerDbContext context) : base(context)
        {
        }

        public SystemType GetById(int id) => _dbSet.Find(id);
        public SystemType GetSystemWithDecks(int id) => _dbSet.Include(st => st.Decks).FirstOrDefault(st => st.Id == id);
    }
}
