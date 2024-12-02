using Emne6_Eksamen.Components.Pages.Interfaces;

namespace Emne6_Eksamen.Components.Pages;

public class BooksService : IBooksService
{
    public List<BooksData> BooksData { get; set; }

    public void SetBooksData(List<BooksData> booksData)
    {
        BooksData = booksData;
    }

    public BooksData GetByID(int id)
    {
        return BooksData.FirstOrDefault(b => b.id == id);
    }
}