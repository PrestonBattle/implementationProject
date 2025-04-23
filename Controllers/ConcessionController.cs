using Microsoft.AspNetCore.Mvc;
using Haven.Models;
using Haven.Models.ConcessionStuff;
namespace Haven.Controllers
{
    public class ConcessionController : Controller
    {

        /*
       private RotateConcessionProduct rotateP;
        public ConcessionController(RotateConcessionProduct rotate)
        {
            rotateP = rotate;
            
        }

        public IActionResult FoodandDrink()
        {
            // rotateP = rotate;
            return View("Concession", rotateP.Products);
        }

        */

        
         
                    private readonly ApplicationDbContext _context;

            public ConcessionController(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult FoodandDrink()
            {
                var items = _context.Concessions.ToList(); // Retrieve from DB
                return View("Concession", items);
            }
         
         


    }
}
