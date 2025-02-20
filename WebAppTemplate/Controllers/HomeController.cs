using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Models;

namespace WebAppTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Other()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(User user)
        {
            return View("FormConfirmation", user);
        }
    }
}
