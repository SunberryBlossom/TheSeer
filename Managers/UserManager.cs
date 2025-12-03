using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Interfaces;
using TheSeer.Models;


namespace TheSeer.Managers
{
    internal class UserManager
    {
        private readonly IDataService _dataService;
        private readonly ICryptographyService _cryptoService;
        private readonly IValidationService _validationService;
        private User? _currentUser;

        public UserManager(IDataService dataService, ICryptographyService cryptoService, IValidationService validationService)
        {
            _dataService = dataService;
            _cryptoService = cryptoService;
            _validationService = validationService;
            _currentUser = null;
        }

        public User? Login(string username, string password)
        {
            var user = _dataService.GetUser(username);

            if (user == null)
            {
                return null;
            }

            bool passwordCorrect = _cryptoService.VerifyPassword(password, user.PasswordHash);

            if (passwordCorrect)
            {
                user.UpdateLastLogin();

                _dataService.SaveUser(user);

                _currentUser = user;

                return user;
            }

            return null;
        }

        public bool NewUser(string username, string password, string email, out string? errorMessage)
        {
            errorMessage = null;

            if (!_validationService.IsValidUsername(username, out errorMessage))
            {
                return false;
            }

            if (!_validationService.IsValidPassword(password, out errorMessage))
            {
                return false;
            }

            if (!_validationService.IsValidEmail(email, out errorMessage))
            {
                return false;
            }

            if (_dataService.GetUser(username) != null)
            {
                errorMessage = "Username already exists.";
                return false;
            }

            string hashedPassword = _cryptoService.HashPassword(password);

            var newUser = new User(username, hashedPassword, email);

            _dataService.SaveUser(newUser);

            return true;
        }

        public void Logout()
        {
            _currentUser = null;
        }

        public User? GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
