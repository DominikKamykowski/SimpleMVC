using Rejestracja.Models;
using System.Collections.Generic;

namespace Rejestracja.Repository
{
    public class UserLocalService : IUserService
    {
        public static List<UserDto> Users = new List<UserDto>()
        {
            new UserDto() { Id = 1, Name = "Jan", LastName = "Kowalski", Email = "test@op.pl", CityId = 1 }
        };
        public void Create(UserDto user)
        {
            Users.Add(user);
        }

        public List<UserDto> Read()
        {
            return Users;
        }


    }
}
