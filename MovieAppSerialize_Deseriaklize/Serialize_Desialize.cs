using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
                
namespace MovieAppSerialize_Deseriaklize
{
    internal class Serialize_Desialize
    {
        public static string SerializeMovies(List<Movie> movies)
        {
            string filePath = "movies.json";
            string json = JsonConvert.SerializeObject(movies, Formatting.Indented);
            File.WriteAllText(filePath, json);
            return json;
        }

        public static List<Movie> DeserializeMovies(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
                return new List<Movie>();
            try
            {
                return JsonConvert.DeserializeObject<List<Movie>>(jsonString) ?? new List<Movie>();
            }
            catch
            {
                return new List<Movie>();
            }
        }
        // save movie in csv file
         public static void SaveMoviesToCsv(List<Movie> movies, string csvFilePath)
        {
            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                writer.WriteLine("Id,Name,Genre,Year");
                foreach (var movie in movies)
                {
                    writer.WriteLine($"{movie.Id},{movie.Name},{movie.Genre},{movie.Year}");
                }
            }

        }
        // Load movies from CSV file
        public static List<Movie> LoadMoviesFromCsv(string csvFilePath)
        {
            List<Movie> movies = new List<Movie>();
            if (!File.Exists(csvFilePath))
                return movies;
            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string headerLine = reader.ReadLine(); 
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var parts = line.Split(',');
                    if (parts.Length == 4 && int.TryParse(parts[0], out int id))
                    {
                        movies.Add(new Movie(id, parts[1], parts[2], parts[3]));
                    }
                }
            }
            return movies;
        }




    }
}