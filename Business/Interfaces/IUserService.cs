using TheSeer.Business.DTOs;
using TheSeer.Domain.Models;

namespace TheSeer.Business.Interfaces
{
    public interface IUserService
    {
        UserSessionDto Login(UserLoginDto loginDto);
        bool Register(UserRegisterDto registerDto);
        UserSessionDto GetUserProfile(Guid userId);
    }
}