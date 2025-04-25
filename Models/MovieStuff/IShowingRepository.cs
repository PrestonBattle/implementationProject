using ThriveHavenMovies.Data;

namespace ThriveHavenMovies.Models.MovieStuff
{
    public interface IShowingRepository
    {

        IEnumerable<Showing> Showings { get; }

        

    }
}
