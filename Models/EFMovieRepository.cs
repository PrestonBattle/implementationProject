namespace Haven.Models
{
    public class EFMovieRepository: IMovieRepository
    {
        private ApplicationDbContext context;
        public EFMovieRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Movie> Movies => context.Movies;
    }
}
