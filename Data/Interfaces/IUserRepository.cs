using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetById(Guid id);
        User GetByEmail(string email);
        User GetFullUserProfile(Guid id);
        User GetByUserName(string username);
    }
}
