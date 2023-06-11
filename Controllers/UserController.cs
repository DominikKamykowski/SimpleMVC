using Microsoft.AspNetCore.Mvc;
using Rejestracja.Models;
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

        public IActionResult Add()
        {
            return View(new UserModel());
        }
        [HttpPost]
		public IActionResult Add(UserModel model)
		{
			if(ModelState.IsValid) 
            {
                userService.Create(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
		}
	}
}
