namespace Haven.Models
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Movies { get; }
    }
}
