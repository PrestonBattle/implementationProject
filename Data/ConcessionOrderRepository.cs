using ThriveHavenMovies.Models.ConcessionStuff;

namespace ThriveHavenMovies.Data
{
    public class ConcessionOrderRepository : IConcessionOrderRepository
    {
        private readonly AppDbContext _context;

        public ConcessionOrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ConcessionOrder> ConcessionOrders => _context.ConcessionOrders;

        public void Add(ConcessionOrder concessionOrder)
        {
            _context.ConcessionOrders.Add(concessionOrder);
            _context.SaveChanges();
        }

        public void Update(ConcessionOrder concessionOrder)
        {
            _context.ConcessionOrders.Update(concessionOrder);
            _context.SaveChanges();
        }

        public void Delete(ConcessionOrder concessionOrder)
        {
            _context.ConcessionOrders.Remove(concessionOrder);
            _context.SaveChanges();

        }
    }
}
