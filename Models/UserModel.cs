using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Rejestracja.Models
{
    public class UserModel : UserDto
    {
        public List<SelectListItem> Cities { get; set; }
        public UserModel() 
        {
            Cities = new List<SelectListItem>() { };
            Cities.Add(new SelectListItem() { Value = "1", Text = "Warszawa" });
            Cities.Add(new SelectListItem() { Value = "2", Text = "Kraków" });
            Cities.Add(new SelectListItem() { Value = "3", Text = "Gdańsk" });
        }
    }
}
