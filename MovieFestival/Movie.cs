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
		public string Genre { get; set; }

		public Movie(string title, int length, string genre)
		{
			Title = title;
			Length = length;
			Genre = genre;
		}

		public string GetData()
		{
			string acronym = !string.IsNullOrEmpty(Genre) ? $"{Genre[0]}{Genre[^1]}" : "";

			return string.Format("Title: {0}, Length: {1}, Genre {2}", Title, Length, acronym);
		}
	}
}
