namespace ThriveHavenMovies.Models.AccountStuff
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> Payments { get; }

        IEnumerable<Payment> GetPaymentsByUser(Guid userId);

        void Add(Payment payment);

        void Update(Payment payment);
        void Delete(Payment payment);

        Payment GetDefaultPayment(Guid userId);
    }
}
