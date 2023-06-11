using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rejestracja.Models;
using Rejestracja.Repository;
using System.Linq;

namespace Rejestracja.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) { 
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.Read());
        }

        public IActionResult Add()
        {
            var Cities = _userService.ReadCities().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            return View(new UserModel() {Cities = Cities });
        }
        [HttpPost]
		public IActionResult Add(UserModel model)
		{
			if(ModelState.IsValid) 
            {
				_userService.Create(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
		}
	}
}
