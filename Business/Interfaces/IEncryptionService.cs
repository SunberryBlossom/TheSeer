using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Business.Interfaces
{
    public interface IEncryptionService
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string hashedPassword);
    }
}
