using Microsoft.AspNetCore.Mvc;

namespace ThriveHaven.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
