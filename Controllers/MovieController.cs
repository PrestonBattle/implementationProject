using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Haven.Models;

namespace Haven.Controllers
{
    public class MovieController:Controller
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
