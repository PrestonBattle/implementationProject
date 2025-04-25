using Microsoft.EntityFrameworkCore;
using ThriveHavenMovies.Models.AccountStuff;

namespace ThriveHavenMovies.Data
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Payment> Payments => _context.Payments;

        public void Add(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public void Update(Payment payment)
        {
            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void Delete(Payment payment)
        {
            _context.Payments.Remove(payment);
            _context.SaveChanges();
        }

        public Payment GetDefaultPayment(Guid userId)
        {
            return _context.Payments
                .FirstOrDefault(p => p.UserId == userId && p.IsDefault);
        }

        
        public IEnumerable<Payment> GetPaymentsByUser(Guid userId)
        {
            return _context.Payments
                .Where(p => p.UserId == userId)
                .ToList();
        }
    }
}
