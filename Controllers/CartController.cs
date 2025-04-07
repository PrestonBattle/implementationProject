using Microsoft.AspNetCore.Mvc;

namespace ThriveHaven.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
