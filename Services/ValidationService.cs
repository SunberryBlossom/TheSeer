using System.Text.RegularExpressions;
using TheSeer.Interfaces;

namespace TheSeer.Services
{
    internal class ValidationService : IValidationService
    {
        private const int MinUsernameLength = 3;
        private const int MaxUsernameLength = 20;
        private const int MinPasswordLength = 8;
        private const int MaxPasswordLength = 128;

        public bool IsValidUsername(string username, out string? errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username cannot be empty.";
                return false;
            }

            if (username.Length < MinUsernameLength || username.Length > MaxUsernameLength)
            {
                errorMessage = $"Username must be between {MinUsernameLength} and {MaxUsernameLength} characters.";
                return false;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                errorMessage = "Username can only contain letters, numbers, and underscores.";
                return false;
            }

            return true;
        }

        public bool IsValidPassword(string password, out string? errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password cannot be empty.";
                return false;
            }

            if (password.Length < MinPasswordLength || password.Length > MaxPasswordLength)
            {
                errorMessage = $"Password must be at least {MinPasswordLength} characters.";
                return false;
            }

            return true;
        }

        public bool IsValidEmail(string email, out string? errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email cannot be empty.";
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            return true;
        }
    }
}
