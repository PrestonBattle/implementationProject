using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ThriveHavenMovies.Data;
using ThriveHavenMovies.Models.AccountStuff;
using ThriveHavenMovies.Models.CartStuff;
using ThriveHavenMovies.Models.ConcessionStuff;

namespace ThriveHavenMovies.Controllers
{
    public class ConcessionsController : Controller
    {
        private readonly IConcessionRepository _concessionRepository;
        private readonly ICartRepository _cartRepository;
        private readonly IConcessionOrderRepository _concessionOrderRepository;
        private readonly UserManager<Users> _userManager;

        // Injecting required repositories and UserManager
        public ConcessionsController(
            IConcessionRepository concessionRepository,
            ICartRepository cartRepository,
            IConcessionOrderRepository concessionOrderRepository,
            UserManager<Users> userManager)
        {
            _concessionRepository = concessionRepository;
            _cartRepository = cartRepository;
            _concessionOrderRepository = concessionOrderRepository;
            _userManager = userManager;
        }

       
        public IActionResult Concessions()
        {
            var concessions = _concessionRepository.Concessions;
            return View("Concessions", concessions);
        }

        [HttpPost]
        public async Task<IActionResult> AddItemToCart(int quantity, int concessionId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }


            var existingCart = _cartRepository.GetCartByUserId(user.Id);

            if (existingCart == null)
            {
                existingCart = new Cart
                {
                    UserId = user.Id
                };
                _cartRepository.Add(existingCart);
            }


            var concessionOrder = new ConcessionOrder
            {
                CartID = existingCart.CartId,
                ItemID = concessionId,
                Quantity = quantity
            };

            _concessionOrderRepository.Add(concessionOrder);
            


            return RedirectToAction("Cart", "Cart");
        }
    }
}
