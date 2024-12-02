namespace Emne6_Eksamen.Components.Pages;

public class BooksResponse
{
    public List<BooksData> results { get; set; }
}

public class BooksData
{
    public int id { get; set; }
    public string title { get; set; }
    public string author { get; set; }
    public DateOnly publication_date { get; set; }
    public List<string> characters { get; set; }
    public string url { get; set; }
}