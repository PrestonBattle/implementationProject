using Microsoft.AspNetCore.Mvc;

namespace ThriveHavenMovies.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
    }
     
}
