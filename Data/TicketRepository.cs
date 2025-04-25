using Microsoft.EntityFrameworkCore;
using ThriveHavenMovies.Models.CartStuff;

namespace ThriveHavenMovies.Data
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _context;

        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ticket> Tickets => _context.Tickets;

        public void Add(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public void Update(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            _context.SaveChanges();
        }

        public void Delete(Ticket ticket)
        {
            var existingTicket = _context.Tickets.Find(ticket.TicketId);
            if (existingTicket != null)
            {
                _context.Tickets.Remove(existingTicket);
                _context.SaveChanges();
            }

        }
    }
}
