using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    public class FestivalProgram
    {
        public DateTime Date { get; set; }

        List<string> Movies {  get; set; }

        public FestivalProgram()
        {
            Movies = new List<string>();
        }

        public void AddMovie(string movie)
        { 
            Movies.Add(movie);
        }

        public string GetData(string movie)
        {
            return movie;
        }
    }
}
