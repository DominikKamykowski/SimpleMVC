using Rejestracja.Models;
using System.Collections.Generic;

namespace Rejestracja.Repository
{
    public interface IUserService
    {
        List<UserDto> Read();

        void Create(UserDto user);
    }
}
