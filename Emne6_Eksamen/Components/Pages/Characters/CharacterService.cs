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
        RealmData r = await _httpClient.GetFromJsonAsync<RealmData>(url);
        return r;
    }

    public async Task<SpeiciesData> GetSpeiciesAsync(string url)
    {
        SpeiciesData s = await _httpClient.GetFromJsonAsync<SpeiciesData>(url);
        return s;
    }

    public async Task<RaceData> GetRaceAsync(string url)
    {
        RaceData r = await _httpClient.GetFromJsonAsync<RaceData>(url);
        return r;
    }

    public async Task<GroupData> GetGroupDataAsync(string url)
    {
        GroupData g = await _httpClient.GetFromJsonAsync<GroupData>(url);
        return g;
    }
}