using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppSerialize_Deseriaklize
{

    // Custom exception for movie limit
    public class MovieLimitExceededException : Exception
    {
        public MovieLimitExceededException() : base("You can only add up to 5 movies at a time.") { }
    }
    // custom exception invalid id 
    public class InvalidMovieInputException : Exception
    {
        public InvalidMovieInputException() : base("Invalid input for movie details. Please try again.") { }
    }







}
