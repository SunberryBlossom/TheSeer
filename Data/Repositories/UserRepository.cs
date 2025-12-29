using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Repositories
{
    internal class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(TheSeerDbContext context) : base(context)
        {
        }

        public User GetById(Guid id) => _dbSet.Find(id);
        public User GetByEmail(string email)
        {
            return _dbSet.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }

        public User GetByUserName(string username) => _dbSet.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
        public User GetFullUserProfile(Guid id)
        {
            return _dbSet
                .Include(u => u.Readings)
                .Include(u => u.JournalEntries)
                .Include(u => u.FavoriteDecks)
                .ThenInclude(fd => fd.Deck)
                .FirstOrDefault(u => u.Id == id);
        }
    }
}
