namespace Haven.Models
{
    public class FakeMovieRepository: IMovieRepository
    {
        public IEnumerable<Movie> Movies => new List<Movie>
        {


             new Movie {MovieID = 1, Name = "La La Land", Genre = "Musical/Romance", Year = "2016", Rating ="PG-13", TimeFrame = "2h 8m", ImageUrl = "/Images/MovieList/La La Land.jpg" },
             new Movie {MovieID = 2, Name = "Ocean's 8", Genre = "Action",Year = "2018", Rating = "PG-13",TimeFrame = "1hr 51m", ImageUrl ="/Images/MovieList/Oceans8.png"},
             new Movie {MovieID = 3, Name = "She's all that",Genre = "Romance/Drama",Year ="1999", Rating ="PG-13",TimeFrame = "1h 35m", ImageUrl = "/Images/MovieList/she's all that.jpg" },



            new Movie {MovieID = 4, Name = "Arrival", Genre = "Sci-Fi/Thriller", Year = "2016", Rating = "PG-13", TimeFrame = "1h 56m", ImageUrl ="/Images/MovieList/Arrival.jpg"},
            new Movie {MovieID = 5, Name = "Baby Driver", Genre = "Action/Thriller", Year = "2017", Rating ="PG-13",TimeFrame = "1h 55m", ImageUrl = "/Images/MovieList/Baby driver.jpg" },
            new Movie {MovieID = 6, Name = "Captain America: Civil War", Genre = "Action/Sci-Fi",Year ="2016",Rating = "PG-13", TimeFrame ="2h 28m", ImageUrl ="/Images/MovieList/Civil war.jpg"},
          
            new Movie {MovieID = 7, Name = "Crazy Rich Asians", Genre = "Romance/Drama",Year = "2018", Rating ="PG-13", TimeFrame = "2h 1m", ImageUrl = "/Images/MovieList/Crazy Rich Asians.jpg" },
            new Movie {MovieID = 8, Name = "Fast and Furious 6",Genre ="Action",Year ="2013", Rating ="PG-13",TimeFrame ="2h 10m" ,ImageUrl = "/Images/MovieList/Fast and Furious 6.jpg" },           
            new Movie {MovieID = 9, Name = "Grown ups", Genre = "Drama/Comedy",Year = "2010", Rating = "PG-13", TimeFrame = "1h 42m",ImageUrl ="/Images/MovieList/Grown Ups.jpg"},
       
            new Movie {MovieID = 10, Name = "Hairspray", Genre = "Musical", Year = "2007", TimeFrame = "1h 57m", Rating ="PG-13", ImageUrl = "/Images/MovieList/HairSpray.jpg" },
            new Movie {MovieID = 11, Name = "Hamilton",Genre = "Musical/Drama", Year ="2020", Rating ="PG-13",TimeFrame = "2h 40m", ImageUrl = "/Images/MovieList/Hamilton.jpg" },           
            new Movie {MovieID = 12, Name = "Hunger Games", Genre = "Action",Year ="2012", Rating = "PG-13", TimeFrame = "2h 56m", ImageUrl ="/Images/MovieList/Hunger Games.jpg"},
        
            new Movie {MovieID = 13, Name = "Mrs.Doubtfire",Genre = "Drama",Year = "1993", Rating ="PG-13", TimeFrame = "2h 6m",ImageUrl = "/Images/MovieList/Mrs.Doubtfire.jpg" },
            new Movie {MovieID = 14, Name = "Rush Hour", Genre = "Action/Thriller", Year = "1998", Rating ="PG-13",TimeFrame = "1h 35m", ImageUrl = "/Images/MovieList/Rush Hour.jpg" },            
            new Movie {MovieID = 15, Name = "Star Wars: The Rise of SkyWalker", Genre = "Sci-Fi/Action",Year ="2019", Rating = "PG-13",TimeFrame = "2h 22m", ImageUrl ="/Images/MovieList/Star wars.jpg"},
          
            new Movie {MovieID = 16, Name = "The Great Gatsby", Genre = "Romance/Drama", Year = "2013", Rating ="PG-13", TimeFrame = "2h 22m", ImageUrl = "/Images/MovieList/The Great Gatsby.jpg" },
            new Movie {MovieID = 17, Name = "The Martian",Genre = "Sci-Fi",Year = "2015", Rating ="PG-13",TimeFrame = "2h 31m", ImageUrl = "/Images/MovieList/The Martian.jpg" },                
            new Movie {MovieID = 18, Name = "Tower Heist", Genre = "Action",Year = "2011", Rating = "PG-13", TimeFrame = "1h 44m", ImageUrl ="/Images/MovieList/Tower Heist.jpg"},
           
            new Movie {MovieID = 19, Name = "West side Story", Genre = "Musical/Romance", Year = "2021", TimeFrame = "2h 36m", Rating ="PG-13", ImageUrl = "/Images/MovieList/West Side Story.jpg" },


             
        
      /*        new Movie {MovieID = 1, Name = "La La Land", Genre = "Romance,Comedy,Musical", Rating = "PG-13", ImageUrl ="/Images/MovieList/lalaland.jpg"},
             new Movie {MovieID = 2, Name = "Ocean's 8", Genre = "Action, Crime", Rating ="PG-13", ImageUrl = "/Images/MovieList/Oceans8.jpg" },
             new Movie {MovieID = 3, Name = "She's all that",Genre = "Romance , Drama", Rating ="PG-13", ImageUrl = "/Images/MovieList/she's all that.jpg" },
         */  
             };
    }
}
