using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      var count = RequestNumber("How many movies do you want?");

      var database = new MovieDatabase();
      var movies = database.GetMovies(count);

      foreach (var movie in movies)
      {
         Console.WriteLine($"Title - {movie.Title}");
      }

      Console.ReadKey();
    }

    public static int RequestNumber(string prompt)
    {
      bool isNumber;
      int number;

      do
      {
        Console.WriteLine(prompt);
        var response = Console.ReadLine();
        isNumber = int.TryParse(response, out number);
      } while (isNumber == false);

      return number;
    }
  }

  public class MovieDatabase
  {
    public List<Movie> GetMovies(int count)
    {
      var result = new List<Movie>();

      for (int i = 1; i <= count; i++)
      {
        var movie = new Movie();
        movie.Title = $"Movie {i}";
        movie.Category = $"Category {i}";

        result.Add(movie);
      }

      return result;
    }
  }

  public class Movie
  {
    public string Title { get; set; }
    public string Category { get; set; }
  }
}
