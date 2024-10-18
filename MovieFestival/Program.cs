using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    public class Program
    {
        public DateTime Date { get; set; }

        List<Movie> Movies {  get; set; }

        public Program()
        {
            Movies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        { 
            Movies.Add(movie);
        }

        public string GetData()
        {
            int totalDuration = 0;
            string details = "";
            foreach (Movie mov in Movies) 
            {
                totalDuration += mov.Length;
                details = details + "\n" + mov.GetData();
            }
            return "Date: " + Date + " Total duration of the Program: " + totalDuration 
                + " Movies: " +Movies.Count + " Program details: "+ details;
        }
    }
}
