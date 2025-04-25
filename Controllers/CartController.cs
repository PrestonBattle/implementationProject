using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThriveHavenMovies.Data;
using ThriveHavenMovies.Models.AccountStuff;
using ThriveHavenMovies.Models.CartStuff;
using ThriveHavenMovies.Models.ConcessionStuff;
using ThriveHavenMovies.Models.MovieStuff;

namespace ThriveHavenMovies.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<Users> _userManager;
        private readonly ICartRepository _cartRepository;
        private readonly IConcessionOrderRepository _concessionOrderRepository;
        private readonly ITicketRepository _ticketRepository;
        private readonly IOrderRepository _orderRepository;
        
        

        public CartController(IOrderRepository orderRepository, ICartRepository cartRepository, UserManager<Users> userManager, AppDbContext dbContext, IConcessionOrderRepository concessionOrderRepository, ITicketRepository ticketRepository)
        {

            _userManager = userManager;
            _cartRepository = cartRepository;  
            _dbContext = dbContext;
            _concessionOrderRepository = concessionOrderRepository;
            _ticketRepository = ticketRepository;
            _orderRepository = orderRepository;
        }
        public async Task<IActionResult> Cart() //function to get all properties associated with the cart
        {
            var userId = _userManager.GetUserId(User);

          
            var cart = await _dbContext.Cart.FirstOrDefaultAsync(c => c.UserId == Guid.Parse(userId));
            var order = await _dbContext.Orders.FirstOrDefaultAsync(c => c.UserId == Guid.Parse(userId));

            if (cart == null)
            {
                return View(new CartViewModel
                {
                    Cart = null,
                    Tickets = new List<Ticket>(),
                    Movies = new List<Movie>(),
                    ConcessionOrders = new List<ConcessionOrder>(),
                    Concessions = new List<Concession>(),
                    
                    Payment = null,
                    Order = null
                });
            }

            var tickets = await _dbContext.Tickets
                .Where(t => t.CartId == cart.CartId)
                .Include(t => t.Movie)
                .ToListAsync();

            var concessionOrders = await _dbContext.ConcessionOrders
                .Where(t => t.CartID == cart.CartId)
                .Include(t => t.Concession)
                .ToListAsync();

            var concessions = concessionOrders.Select(t => t.Concession).Distinct().ToList();
            
            var movies = tickets.Select(t => t.Movie).Distinct().ToList();

            var payment = await _dbContext.Payments
                .FirstOrDefaultAsync(p => p.UserId == Guid.Parse(userId));

            var model = new CartViewModel
            {
                Cart = cart,
                Tickets = tickets,
                Movies = movies,
                Payment = payment,
                ConcessionOrders = concessionOrders,
                Concessions = concessions,
                Order = order
            };

            return View(model);
        }

        //post endpoints to deal with delete items

        [HttpPost]

        public async Task<IActionResult> DeleteConcessionOrder(int id)
        {
            var concessionOrder = _concessionOrderRepository.ConcessionOrders.FirstOrDefault(t => t.OrderID == id);
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            _concessionOrderRepository.Delete(concessionOrder);
            return RedirectToAction("Cart");
        }

        [HttpPost]

        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = _ticketRepository.Tickets.FirstOrDefault(t => t.TicketId == id);
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            _ticketRepository.Delete(ticket);
            return RedirectToAction("Cart");
        }

        //Endpoint to delete cart instance and create ticket

        [HttpPost]

        public async Task<IActionResult> ProcessOrder()
        {
            
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var userId = _userManager.GetUserId(User);

            var cart = await _dbContext.Cart.FirstOrDefaultAsync(c => c.UserId == Guid.Parse(userId));


            var newOrder = new Order
            {
                UserId = user.Id,
        
            };

            _dbContext.Orders.Add(newOrder);
            await _dbContext.SaveChangesAsync();

            var tickets = await _dbContext.Tickets
                .Where(t => t.CartId == cart.CartId)
                .ToListAsync();
            foreach (var t in tickets)
            {
                t.CartId = null;
                t.OrderId = newOrder.Id;
                await _dbContext.SaveChangesAsync();
            }

            var concessionOrders = await _dbContext.ConcessionOrders
                .Where(t => t.CartID == cart.CartId)
                .ToListAsync();
            foreach (var t in concessionOrders)
            {
                t.CartID = null;
                t.UserOrderId = newOrder.Id;
                await _dbContext.SaveChangesAsync();
            }
            _cartRepository.Delete(cart);
            await _dbContext.SaveChangesAsync();
            return StatusCode(204);

        }

    }
}
