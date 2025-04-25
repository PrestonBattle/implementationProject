using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ThriveHavenMovies.Data;
using ThriveHavenMovies.Models.AccountStuff;
using ThriveHavenMovies.Models.CartStuff;
using ThriveHavenMovies.Models.MovieStuff;

namespace ThriveHavenMovies.Controllers
{
    public class TicketController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly ICartRepository _cartRepository;
        private readonly UserManager<Users> _userManager;



        public TicketController(
            IMovieRepository movieRepository,
            ITicketRepository ticketRepository,
            ICartRepository cartRepository,
            UserManager<Users> userManager)
        {
            _movieRepository = movieRepository;
            _ticketRepository = ticketRepository;
            _cartRepository = cartRepository;
            _userManager = userManager;
        }

        public IActionResult TicketView(string name)
        {
            //var movie = _movieRepository.Movies.FirstOrDefault(movie => movie.Name == name);
            var movie = _movieRepository.getMovieName(name);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> AddTicket(int quantity, string selectedTime, string selectedDate, int movieId)
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

            var ticket = new Ticket
            {
                MovieId = movieId,
                ticketDate = selectedDate,
                ticketTime = selectedTime,
                CartId = existingCart.CartId,
                Quantity = quantity,
                
            };

            _ticketRepository.Add(ticket);

            return RedirectToAction("Cart", "Cart");



        }

    }
}
