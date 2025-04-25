using Microsoft.AspNetCore.Mvc;
using ThriveHavenMovies.Models.MovieStuff;

namespace ThriveHavenMovies.Controllers
{
    public class MovieController : Controller
    {
        private IMovieRepository repository;
        public int PageSizes = 3;
        public MovieController(IMovieRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Movies);

        public ViewResult TicketView()
        {
            return View();
        }

    }
}
