using Microsoft.AspNetCore.Mvc.Rendering;

namespace Rejestracja.Models
{
    public class UserModel : UserDto
    {
        public SelectList City { get; set; }
        public UserModel() { }
    }
}
