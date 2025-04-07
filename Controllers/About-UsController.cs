using Microsoft.AspNetCore.Mvc;

namespace ThriveHaven.Controllers
{
    public class About_UsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
