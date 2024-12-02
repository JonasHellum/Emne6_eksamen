namespace Emne6_Eksamen.Components.Pages.Interfaces;

public interface ICharacterService : IBaseService<CharacterData>
{
    Task<RealmData> GetRealmAsync(string url);
    Task<SpeiciesData> GetSpeiciesAsync(string url);
    Task<RaceData> GetRaceAsync(string url);
    Task<GroupData> GetGroupDataAsync(string url);
}