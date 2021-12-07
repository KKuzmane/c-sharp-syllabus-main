using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Movie
    {
        public Movie(string title, string studio, string rating)
            {
                _title = title;
                _studio = studio;
                _rating = rating;
            }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }
        public string _title { get; set; }
        public string _studio { get; set; }
        public string _rating { get; set; }

        static void Main(string[] args)
        {
            var spiderMan = new Movie("Spider Man", "Marvel");
            var casinoRoyale = new Movie("Casino Royale", "Studio 2", "PG13");
            var glass = new Movie("Glass", "Studio1", "PG13");
            var movies = new List<Movie>            {
                spiderMan,
                casinoRoyale,
                glass
            };

            var filtered = GetPg(movies.ToArray());
            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie}");
            }

            Console.ReadKey();
        }

        public static Movie[] GetPg(Movie[] movies)
        { 
            var filtered = new List<Movie>();
            foreach(var movie in movies)
            {
                if (movie._rating == "PG")
                {
                    filtered.Add(movie);
                }
            }
            return filtered.ToArray();
        }
    }
}
