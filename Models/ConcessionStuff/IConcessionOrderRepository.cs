namespace ThriveHavenMovies.Models.ConcessionStuff
{
    public interface IConcessionOrderRepository
    {
        IEnumerable<ConcessionOrder> ConcessionOrders { get; }

        void Add(ConcessionOrder concessionOrder);

        void Update(ConcessionOrder concessionOrder);
        void Delete(ConcessionOrder concessionOrder);
    }
}
