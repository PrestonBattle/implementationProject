using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ThriveHavenMovies.Models.CartStuff;

namespace ThriveHavenMovies.Models.ConcessionStuff
{
    public class ConcessionOrder
    {

        [Key]
        public int OrderID { get; set; }


        public int? CartID { get; set; }

        [ForeignKey("CartID")]
        public Cart Cart { get; set; }

        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
       
        public Concession Concession { get; set; }
        public int Quantity { get; set; }

         public int? UserOrderId { get; set; }

        [ForeignKey("UserOrderId")]
        public Order Order { get; set; }

    }
}
