using Haven.Models.ConcessionStuff;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haven.Models
{
    public class Cart
    {

        [Key]
        public int CartID { get; set; }

        
        /*
         [ForeignKey("ConcessionOrder")]
        public int OrderID { get; set; }

        

        public ConcessionOrder ConcessionOrder { get; set; }
        */
}
}
