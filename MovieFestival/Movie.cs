namespace MovieFestival;

public class Movie
{
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public int Length { get; set; }

    public Movie(string title, Genre genre, int length)
    {
        Title = title;
        Genre = genre;
        Length = length;
    }

    public string GetData()
    {
        return $"{Title}, {Length} min, {Genre.GetData()}";
    }
}
