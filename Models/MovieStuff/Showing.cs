using System.ComponentModel.DataAnnotations.Schema;

namespace ThriveHavenMovies.Models.MovieStuff
{
    public class Showing
    {
        public int Id { get; set; }

        public string ShowingDate { get; set; }

        public string ShowingTime { get; set; }

       public int AuditoriumId { get; set; }

        //public int MovieId { get; set; }

        //[ForeignKey("MovieId")]
        //public Movie Movie { get; set; }
    }
}
