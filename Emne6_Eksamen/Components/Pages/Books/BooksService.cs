using Emne6_Eksamen.Components.Pages.Interfaces;

namespace Emne6_Eksamen.Components.Pages;

public class BooksService : IBooksService
{
    public List<BooksData> BooksData { get; set; }
    private readonly HttpClient _httpClient;

    public BooksService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public void SetBooksData(List<BooksData> booksData)
    {
        BooksData = booksData;
    }

    public BooksData GetByID(int id)
    {
        return BooksData.FirstOrDefault(b => b.id == id);
    }

    public async Task<List<CharactersCharData>> GetCharactersAsync(List<string> url)
    {
        var tasks = new List<Task<CharactersCharData>>();

        foreach (var urls in url)
        {
            tasks.Add(_httpClient.GetFromJsonAsync<CharactersCharData>(urls));
        }

        try
        {
            var characters = await Task.WhenAll(tasks);
            return characters.Where(c => c != null).ToList();
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return new List<CharactersCharData>();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return new List<CharactersCharData>();
        }
    }
}