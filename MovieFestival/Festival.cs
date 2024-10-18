using System;
using System.Collections.Generic;

public class Program
{
    public string Title { get; set; }
    public DateTime Date { get; set; }

    public Program(string title, DateTime date)
    {
        Title = title;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Title} on {Date.ToShortDateString()}";
    }
}

public class Festival
{
    public string Name { get; set; }
    private List<Program> Programs { get; set; }

    public Festival(string name)
    {
        Name = name;
        Programs = new List<Program>();
    }

    public void AddProgram(string title, DateTime date)
    {
        var program = new Program(title, date);
        Programs.Add(program);
    }

    public string GetData()
    {
        var programDetails = string.Join(Environment.NewLine, Programs);
        return $"Festival: {Name}\nTotal Programs: {Programs.Count}\nPrograms:\n{programDetails}";
    }
}

