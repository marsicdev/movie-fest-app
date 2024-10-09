public class Genre
{
    public string Name { get; set; }

    public Genre(string name)
    {
        Name = name;
    }

    public string GetData()
    {
        if (string.IsNullOrEmpty(Name)) return string.Empty;

        if (Name.Length == 1) return Name.ToUpper();

        return (Name[0] + Name[^1].ToString()).ToUpper();
    }
}
