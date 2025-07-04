using System;
using System.Collections.Generic;
using System.IO;

namespace MovieAppSerialize_Deseriaklize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "movies.json";
            List<Movie> movies;

            // Load movies from file if it exists
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                movies = Serialize_Desialize.DeserializeMovies(json);
            }
            else
            {
                movies = new List<Movie>();
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSimpleMoviesApp Menu:");
                Console.WriteLine("1. Display movies");
                Console.WriteLine("2. Add movies ");
                Console.WriteLine("3. clear Movies");
                Console.WriteLine("4. Edit a movie by Id");
                Console.WriteLine("5. Remove a movie by Id");


                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                        case "1":
                        if (movies.Count == 0)
                        {
                            throw new InvalidOperationException("No movies available to display.");


                        }
                        else
                        {
                            foreach (var movie in movies)
                            {
                                movie.DisplayMovieDetails();
                            }
                            
                        }

                        break;
                    case "2":
                    // Add movies from user input
                        try
                        {
                            movies = Movie.AddMoviesFromUserInput(movies);
                            // Serialize and save to file
                            string json = Serialize_Desialize.SerializeMovies(movies);
                            //csv file path
                            string csvFilePath = "movies.csv";
                            Serialize_Desialize.SaveMoviesToCsv(movies, csvFilePath);

                            File.WriteAllText(filePath, json);
                        }
                        catch (MovieLimitExceededException)
                        {
                            Console.WriteLine("You can only add up to 5 movies at a time.");
                        }
                        catch (InvalidMovieInputException)
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                        break;







                    case "3":
                        // Exception handling for clearing movies
                        if (movies.Count == 0)
                        {
                            throw new InvalidOperationException("No movies available to clear.");
                        }
                        movies.Clear();
                        Serialize_Desialize.SerializeMovies(movies);

                        File.WriteAllText(filePath, string.Empty); // Clear the file


                        Console.WriteLine("All movies cleared.");
                        break;
                    case "4":
                        //  call the method for editing a movie
                        if (movies.Count == 0)
                        {
                            throw new InvalidOperationException("No movies available to edit.");
                        }
                        Console.Write("Enter the Id of the movie to edit: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            var movie = Movie.FindMovieById(movies, id);
                            if (movie != null)
                            {
                                Console.Write("Enter new Name: ");
                                movie.Name = Console.ReadLine() ?? movie.Name;
                                Console.Write("Enter new Genre: ");
                                movie.Genre = Console.ReadLine() ?? movie.Genre;
                                Console.Write("Enter new Year: ");
                                movie.Year = Console.ReadLine() ?? movie.Year;
                                // Save changes
                                string updatedJson = Serialize_Desialize.SerializeMovies(movies);
                                //csv file path
                                string csvFilePath = "movies.csv";

                                // uddate the  csv file
                                Serialize_Desialize.SaveMoviesToCsv(movies, csvFilePath);





                             File.WriteAllText(filePath, updatedJson);
                                Console.WriteLine("Movie updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine($"No movie found with Id {id}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Id.");
                        }
                        break;
                    case "5":
                        // remove movie by id
                        if (movies.Count == 0)
                        {
                            throw new InvalidOperationException("No movies available to remove.");
                        }
                        Console.Write("Enter the Id of the movie to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            Movie.RemoveMovieById(movies, removeId);
                            // Save changes
                            string updatedJson = Serialize_Desialize.SerializeMovies(movies);
                            File.WriteAllText(filePath, updatedJson);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Id.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;



                        
                        
                        





                
                }
            }
        }
    }
}   