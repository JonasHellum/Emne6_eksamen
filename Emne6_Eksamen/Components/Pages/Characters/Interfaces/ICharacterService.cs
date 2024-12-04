namespace Emne6_Eksamen.Components.Pages.Interfaces;

public interface ICharacterService : IBaseService<CharacterData>
{
    Task<RealmData> GetRealmAsync(string url);
    Task<SpeiciesData> GetSpeiciesAsync(string url);
    Task<RaceData> GetRaceAsync(string url);
    Task<GroupData> GetGroupAsync(string url);
    Task<List<FilmsData>> GetFilmsAsync(List<string> url);
    Task<List<BooksCharData>> GetBooksAsync(List<string> url);
    Task<List<LanguagesData>> GetLanguagesAsync(List<string> url);
}