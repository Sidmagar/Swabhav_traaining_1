using System;

namespace MoviesApp_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = SerializationHelper.Load();
            int count = 0;

            foreach (var m in movies)
            {
                if (m != null) count++;
            }

            while (true)
            {
                Console.WriteLine("\n--- Movie Menu ---");
                Console.WriteLine("1. Display Movies");
                Console.WriteLine("2. Add Movie");
                Console.WriteLine("3. Clear All");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n-- Movie List --");
                        bool hasMovies = false;
                        foreach (var m in movies)
                        {
                            if (m != null)
                            {
                                m.Display();
                                hasMovies = true;
                            }
                        }
                        if (!hasMovies)
                            Console.WriteLine("No movies available.");
                        break;

                    case "2":
                        if (count >= 5)
                        {
                            Console.WriteLine("Only 5 movies allowed.");
                        }
                        else
                        {
                            Console.Write("Enter Movie ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Genre: ");
                            string genre = Console.ReadLine();
                            Console.Write("Enter Year: ");
                            int year = int.Parse(Console.ReadLine());

                            Movie newMovie = new Movie(id, name, genre, year);
                            movies[count] = newMovie;
                            count++;
                            SerializationHelper.Save(movies);
                            Console.WriteLine("Movie added successfully.");
                        }
                        break;

                    case "3":
                        movies = new Movie[5];
                        count = 0;
                        SerializationHelper.ClearData();
                        Console.WriteLine("All movies cleared.");
                        break;

                    case "4":
                        SerializationHelper.Save(movies);
                        Console.WriteLine("Exiting and saving...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
