using System.ComponentModel.DataAnnotations;

namespace ThriveHavenMovies.Models.ConcessionStuff
{
    public class Concession
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Cost { get; set; }
        public string ImageUrl { get; set; }
    }
}
