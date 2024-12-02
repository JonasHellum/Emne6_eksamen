namespace Emne6_Eksamen.Components.Pages.Interfaces;

public interface IBaseService<T> where T : class
{
    T GetByID(int id);
}