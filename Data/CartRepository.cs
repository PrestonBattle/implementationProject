using ThriveHavenMovies.Models.CartStuff;

namespace ThriveHavenMovies.Data
{
    public class CartRepository : ICartRepository
    {

        private readonly AppDbContext _context;

        public CartRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Cart> GetCartByUser(Guid userId)
        {
            return _context.Cart.Where(c => c.UserId == userId).ToList();
        }

        public IEnumerable<Cart> Cart => _context.Cart;

        public Cart Add(Cart cart)
        {
            var createdCart = _context.Cart.Add(cart);
            _context.SaveChanges();
            return createdCart.Entity;
        }

        public void Update(Cart cart)
        {
            _context.Cart.Update(cart);
            _context.SaveChanges();
        }

        public void Delete(Cart cart)
        {
            _context.Cart.Remove(cart);
            _context.SaveChanges();

        }

        public Cart? GetCartByUserId(Guid userId)
        {
            return _context.Cart.FirstOrDefault(c => c.UserId == userId);
        }
    }
}
