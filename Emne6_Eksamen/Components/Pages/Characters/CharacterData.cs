namespace Emne6_Eksamen.Components.Pages;

public class CharacterData
{
    public int id { get; set; }
    public string name { get; set; }
    public string realm { get; set; }
    public string height { get; set; }
    public string hair_color { get; set; }
    public string eye_color { get; set; }
    public string date_of_birth { get; set; }
    public string date_of_death { get; set; }
    public string gender { get; set; }
    public string species { get; set; }
    public string race { get; set; }
    public string group { get; set; }
    public List<string> weapons { get; set; }
    public List<string> languages { get; set; }
    public List<string> films { get; set; }
    public List<string> books { get; set; }
}

public class CharacterResponse
{
    public List<CharacterData> results { get; set; }
}

public class RealmData
{
    public string name { get; set; }
}

public class SpeiciesData
{
    public string name { get; set; }
}

public class RaceData
{
    public string name { get; set; }
}

public class GroupData
{
    public string name { get; set; }
}

public class FilmsData
{
    public string title { get; set; }
}

public class BooksCharData
{
    public string title { get; set; }
}

public class LanguagesData
{
    public string name { get; set; }
}