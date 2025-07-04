using System;

namespace MovieAppSerialize_Deseriaklize
{
    internal class Movie      
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        public Movie() { }

        public Movie(int id, string name, string genre, string year)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Year = year;
           
        }

        public void DisplayMovieDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Genre: {Genre}, Year: {Year}");
        }

        // Add movies from user input (up to 5)
        public static List<Movie> AddMoviesFromUserInput(List<Movie> movies)
        {
            Console.Write("How many movies do you want to add (max 5)? ");
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                if (count > 5)
                {
                    throw new MovieLimitExceededException();
                }
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Enter details for movie {i + 1}:");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Name: ");
                    string name = Console.ReadLine() ?? string.Empty;
                    Console.Write("Genre: ");
                    string genre = Console.ReadLine() ?? string.Empty;
                    Console.Write("Year: ");
                    string year = Console.ReadLine() ?? string.Empty;
                    movies.Add(new Movie(id, name, genre, year));
                }
            }
            else
            {
                throw new InvalidMovieInputException();
            }
            return movies;
        }
        // find movie by id
        public static Movie FindMovieById(List<Movie> movies, int id)
        {
            return movies.FirstOrDefault(m => m.Id == id);
            

        }
        //remove movie by id
        public static void RemoveMovieById(List<Movie> movies, int id)
        {
            var movie = FindMovieById(movies, id);
            if (movie != null)
            {
                movies.Remove(movie);
                Console.WriteLine($"Movie with Id {id} has been removed.");
            }
            else
            {
                Console.WriteLine($"No movie found with Id {id}.");
            }
            
        }
    }
}