using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Domain.Models;

namespace TheSeer.Data.Interfaces
{
    internal interface ISystemTypeRepository : IGenericRepository<SystemType>
    {
        SystemType GetById(int id);
        SystemType GetSystemWithDecks(int id);
    }
}
