namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi from App");
    }

    public string CreateProgram()
    {
        string date = ReadUserInput("Insert program date");

        return "new Program(date);";
    }

    public string CreateMovie()
    {
        string title = ReadUserInput("Insert movie title");
        string length = ReadUserInput("Insert movie length");
        string genre = ReadUserInput("Insert movie genre");

        return "new Movie(title, length, genre);";
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

