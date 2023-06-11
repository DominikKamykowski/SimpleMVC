using Microsoft.AspNetCore.Mvc;
using Rejestracja.Repository;

namespace Rejestracja.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController() { 
        userService = new UserLocalService();
        }
        public IActionResult Index()
        {
            return View(userService.Read());
        }
    }
}
