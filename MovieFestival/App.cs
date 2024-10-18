namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi from App");
    }

    public Program CreateProgram()
    {
        string date = ReadUserInput("Insert program date");
        Program program = new Program
        {
            Date = DateTime.Parse(date)
        };

        return program;
    }

    public Movie CreateMovie()
    {
        string title = ReadUserInput("Insert movie title");
        string length = ReadUserInput("Insert movie length");
        string genreStr = ReadUserInput("Insert movie genre");
        Genre genre = new Genre(genreStr);

        return new Movie(title, int.Parse(length), genre);
    }

    private string ReadUserInput(string message)
    {
        string? userInput = null;

        while (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine(message);
            userInput = Console.ReadLine();
        }

        return userInput;
    }
}

