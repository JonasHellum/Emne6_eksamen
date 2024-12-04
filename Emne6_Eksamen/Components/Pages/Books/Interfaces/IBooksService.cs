namespace Emne6_Eksamen.Components.Pages.Interfaces;

public interface IBooksService : IBaseService<BooksData>
{
    Task<List<CharactersCharData>> GetCharactersAsync(List<string> url);
}