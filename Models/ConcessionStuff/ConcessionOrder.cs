using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haven.Models.ConcessionStuff
{
    public class ConcessionOrder
    {

        [Key]
        public int OrderID { get; set; }


        public int CartID { get; set; }
        [ForeignKey("CartID")]
        public Cart Cart { get; set; }  // Navigation property to Cart

        [ForeignKey("Concession")]
        public int ItemID { get; set; }
        
        public int Quantity { get; set; }

        
        public Concession Concession { get; set; }  // Navigation property to Concession

    }//End of class ConcessionOrder
}
