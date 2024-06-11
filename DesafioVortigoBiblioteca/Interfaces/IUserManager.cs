namespace DesafioVortigoBiblioteca.Interfaces;

public interface IUserManager
{
    public void AddUser(string name, string email, int id);
    public void ListUser();
    public UserManager FindUser(int id);
    public void RemoveUser(int id);
}