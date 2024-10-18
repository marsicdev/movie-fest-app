using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	public class Movie
	{
		public string Title { get; set; }
		public int Length { get; set; }
		public Genre Genre { get; set; }
		public int ReleaseYear { get; set; }

		public Movie(string title, int length, Genre genre, int releaseYear)
		{
			Title = title;
			Length = length;
			Genre = genre;
			ReleaseYear = releaseYear;
		}

		public string GetData()
		{
			return string.Format("Title: {0}, Length: {1}min, Genre {2}, Release Year: {3} ", Title, Length, Genre.GetData(), ReleaseYear);
		}
	}
}
