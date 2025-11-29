using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSeer.Models
{
    internal class User
    {
        private string Username { get; set; }
        private string PasswordHash { get; set; }
        private string Email { get; set; }
        private string Nickname { get; set; }

        public User(string username, string passwordHash, string email, string nickname)
        {
            UpdateUsername(username);
            UpdatePassword(passwordHash);
            UpdateEmail(email);
            UpdateNickname(nickname);
        }


        // ------------- Update methods for user properties -------------- //
        public void UpdatePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmail(string newEmail)
        {
            throw new NotImplementedException();
        }

        public void UpdateNickname(string newNickname)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsername(string newUsername)
        {
            throw new NotImplementedException();
        }

        // ----------------------------------------------- //

        public void GetUserInfo(string infoWanted)
        {
            throw new NotImplementedException();
        }



    }
}
