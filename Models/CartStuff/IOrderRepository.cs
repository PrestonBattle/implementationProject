namespace ThriveHavenMovies.Models.CartStuff
{
    public interface IOrderRepository
    {

        IEnumerable<Order> Orders { get; }
        void Add(Order item);

        void Update(Order item);   
        void Delete(Order item);


    }
}
