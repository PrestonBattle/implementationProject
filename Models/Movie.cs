using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Haven.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string Year { get; set; }
        public string TimeFrame { get; set; }
        public string ImageUrl { get; set; }
    }
}
