using System;
using TheSeer.Business.Interfaces;
using TheSeer.Business.DTOs;
using TheSeer.Data.Interfaces;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IEncryptionService _encryption;

        public UserService(IUnitOfWork uow, IEncryptionService encryption)
        {
            _uow = uow;
            _encryption = encryption;
        }

        public UserSessionDto Register(UserRegisterDto registerDto)
        {
            var existingUser = _uow.Users.GetByEmail(registerDto.Email);
            if (existingUser != null)
            {
                throw new InvalidOperationException("This Email address is already registered");
            }

            string passwordHash = _encryption.HashPassword(registerDto.Password);

            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Username = registerDto.Username,
                Email = registerDto.Email,
                HashedPassword = passwordHash,
                CreatedAt = DateTime.Now
            };

            _uow.Users.Add(newUser);
            _uow.Save();

            return new UserSessionDto
            {
                Id = newUser.Id,
                Username = newUser.Username,
                Email = newUser.Email
            };
        }

        public UserSessionDto Login(UserLoginDto loginDto)
        {
            var user = _uow.Users.GetByEmail(loginDto.Email);

            if (user == null)
            {
                return null;
            }

            bool isPasswordValid = _encryption.VerifyPassword(loginDto.Password, user.HashedPassword);

            if (!isPasswordValid)
            {
                return null;
            }

            return new UserSessionDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email
            };
        }

        public UserSessionDto GetUserProfile(Guid userId)
        {
            var user = _uow.Users.GetFullUserProfile(userId);

            if (user == null) return null;

            return new UserSessionDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email
            };
        }
    }
}