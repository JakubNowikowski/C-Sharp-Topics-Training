using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class MovieRepository
    {
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(){Title="Star wars", TicketPrice=15},
                new Movie(){Title="Rocky", TicketPrice=16},
                new Movie(){Title="Men in Black", TicketPrice=35},
                new Movie(){Title="James Bond", TicketPrice=25},
                new Movie(){Title="Batman", TicketPrice=30}
            };
        }
    }
}
