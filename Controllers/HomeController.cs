using Microsoft.AspNetCore.Mvc;

namespace ThriveHaven.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
