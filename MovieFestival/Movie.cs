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

		public Movie(string title, int length, Genre genre)
		{
			Title = title;
			Length = length;
			Genre = genre;
		}

		public string GetData()
		{
			return string.Format("Title: {0}, Length: {1}, Genre {2}", Title, Length, Genre.GetData());
		}
	}
}
