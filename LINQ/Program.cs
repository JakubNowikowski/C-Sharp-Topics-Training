using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new MovieRepository().GetMovies();

            // LINQ Query Operators
            var lowPriceMoviesAsQueryOperators =
                from m in movies
                where m.TicketPrice < 20
                orderby m.TicketPrice
                select m.Title;

            // LINQ Extension Methods
            var lowPriceMovies = movies
                .Where(m => m.TicketPrice < 20)
                .OrderBy(m => m.TicketPrice)
                .Select(m => m.Title);

            Console.WriteLine("Low price movies:\n");

            foreach (var movie in lowPriceMovies)
                Console.WriteLine(movie);

            Console.WriteLine("\nTotal price off all movie tickets:\n");

            var totalPrice = movies.Sum(m=>m.TicketPrice);

            Console.WriteLine(totalPrice);

            Console.WriteLine("\nThe most expensive movie:\n");

            var maxPrice = movies.Max(m => m.TicketPrice);
            var mostExpensiveMovie = movies.SingleOrDefault(m => m.TicketPrice == maxPrice).Title;

            Console.WriteLine(mostExpensiveMovie);

            Console.ReadKey();
        }
    }
}
