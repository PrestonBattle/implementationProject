using Microsoft.EntityFrameworkCore;
using ThriveHavenMovies.Models.MovieStuff;

namespace ThriveHavenMovies.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> Movies => _context.Movies.AsNoTracking();

        public Movie GetMovieById(Guid id)
        {
            return _context.Movies.Find(id);
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(Guid id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
        public Movie getMovieName(string name)
        {
            return _context.Movies
                .AsNoTracking()
                .FirstOrDefault(m => m.Name.ToLower() == name.ToLower());
        }

    }
}

