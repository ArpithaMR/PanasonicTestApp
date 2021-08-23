using System;
using System.Collections.Generic;

namespace PanasonicApp.Models
{
    public class MovieList
    {
        public int page { get; set; }
        public List<Movie> results { get; set; }
    }
}
