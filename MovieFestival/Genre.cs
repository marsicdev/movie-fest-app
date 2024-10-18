namespace MovieFestival
{
    public class Genre
    {
        public string Name { get; set; }

        public Genre(string name)
        {
            Name = name;
        }

        public string GetData()
        {
            if (!string.IsNullOrEmpty(Name))
                return $"{Name[0]}{Name[Name.Length - 1]}";
            else
                return string.Empty;
        }
    }
}