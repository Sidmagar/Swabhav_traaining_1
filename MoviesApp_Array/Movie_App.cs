using System;

namespace MoviesApp_Array
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Movie() { }

        public Movie(int movieId, string name, string genre, int year)
        {
            MovieId = movieId;
            Name = name;
            Genre = genre;
            Year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {MovieId}, Name: {Name}, Genre: {Genre}, Year: {Year}");
        }
    }
}
