using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Xml;

namespace MoviesApp_Array
{
    public class SerializationHelper
    {
        private static readonly string filePath = "moviesData.json";

        public static void Save(Movie[] movies)
        {
            var nonNullMovies = movies.Where(m => m != null).ToArray();
            var json = JsonConvert.SerializeObject(nonNullMovies, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(filePath, json);
        }

        public static Movie[] Load()
        {
            if (!File.Exists(filePath))
                return new Movie[5];

            var json = File.ReadAllText(filePath);
            var loaded = JsonConvert.DeserializeObject<Movie[]>(json) ?? new Movie[0];

            Movie[] result = new Movie[5];
            for (int i = 0; i < loaded.Length && i < 5; i++)
                result[i] = loaded[i];

            return result;
        }

        public static void ClearData()
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
