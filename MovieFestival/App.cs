namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {

        string genre = new Genre("Drama").GetData();
        string movieOutput = new Movie("The Shawshank Redemption", new Genre("Drama"), 142).GetData();

        Console.WriteLine(movieOutput);
    }
}

