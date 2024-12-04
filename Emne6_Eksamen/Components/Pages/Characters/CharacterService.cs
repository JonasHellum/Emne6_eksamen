using Emne6_Eksamen.Components.Pages.Interfaces;

namespace Emne6_Eksamen.Components.Pages;

public class CharacterService : ICharacterService
{
    
    public List<CharacterData> CharacterData { get; set; }
    private readonly HttpClient _httpClient;

    public CharacterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public void SetCharacterData(List<CharacterData> characterData)
    {
        CharacterData = characterData;
    }
    
    public CharacterData GetByID(int id)
    {
        return CharacterData.FirstOrDefault(c => c.id == id);
    }

    public async Task<RealmData> GetRealmAsync(string url)
    {
        return await ExecuteAsync(url, new RealmData());
    }

    public async Task<SpeiciesData> GetSpeiciesAsync(string url)
    {
        return await ExecuteAsync(url, new SpeiciesData());
    }

    public async Task<RaceData> GetRaceAsync(string url)
    {
        return await ExecuteAsync(url, new RaceData());
    }

    public async Task<GroupData> GetGroupAsync(string url)
    {
        return await ExecuteAsync(url, new GroupData());
    }

    public async Task<List<FilmsData>> GetFilmsAsync(List<string> url)
    {
        return await ExecuteCollectionAsync<FilmsData>(url);
        
    }
    
    public async Task<List<BooksCharData>> GetBooksAsync(List<string> url)
    {
        return await ExecuteCollectionAsync<BooksCharData>(url);
    }

    public async Task<List<LanguagesData>> GetLanguagesAsync(List<string> url)
    {
        return await ExecuteCollectionAsync<LanguagesData>(url);
    }
    
    private async Task<T> ExecuteAsync<T>(string url, T defaultValue)
    {
        try
        {
            var result = await _httpClient.GetFromJsonAsync<T>(url);
            return result ?? defaultValue;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return defaultValue;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return defaultValue;
        }
    }
    
    private async Task<List<T>> ExecuteCollectionAsync<T>(List<string> url)
    {
        var tasks = new List<Task<T>>();
        foreach (var urls in url)
        {
            var fetchTask = _httpClient.GetFromJsonAsync<T>(urls);
            tasks.Add(fetchTask);
        }

        try
        {
            var results = await Task.WhenAll(tasks);
            return results.Where(r => r != null).ToList();
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return new List<T>();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return new List<T>();
        }
    }
}