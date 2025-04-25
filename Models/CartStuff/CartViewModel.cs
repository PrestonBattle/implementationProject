using Humanizer;
using ThriveHavenMovies.Models.AccountStuff;
using ThriveHavenMovies.Models.ConcessionStuff;
using ThriveHavenMovies.Models.MovieStuff;

namespace ThriveHavenMovies.Models.CartStuff
{
    public class CartViewModel
    {


        public Cart Cart { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Movie> Movies { get; set; }
        public Payment Payment { get; set; }

        public Order Order { get; set; }

        public List<Concession> Concessions { get; set; }

        public List<ConcessionOrder> ConcessionOrders { get; set; }

        public int totalTickets => Tickets.Sum(t => t.Quantity);
        public int totalFoodItems => ConcessionOrders.Sum(t => t.Quantity);

        public int totalItems => totalTickets + totalFoodItems;

        public double TotalTicketCost => Tickets.Sum(t => t.Quantity * t.Cost); 
        public double TotalConcessionCost => ConcessionOrders.Sum(c => c.Quantity * c.Concession.Cost); 
        public double TotalCost => TotalTicketCost + TotalConcessionCost;

    }
}
