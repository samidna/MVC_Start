using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Samid";
            ViewData["Surname"] = "Aghayev";
            ViewData["Age"] = "25";
            ViewData["Country"] = "Azerbaijan";
            ViewData["PhoneNumber"] = "+994554127945";
            return View();
        }
    }
}
