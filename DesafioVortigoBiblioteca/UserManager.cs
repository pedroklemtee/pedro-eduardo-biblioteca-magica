using DesafioVortigoBiblioteca.Interfaces;

namespace DesafioVortigoBiblioteca;



public class UserManager : IUserManager
{
    private Dictionary<int, User> UserList = new Dictionary<int, User>();
    public int IdFind;

    public void AddUser(string name, string email, int id)
    {
        var newUser = new User (name, email, id);
        UserList.Add(id, newUser);
    }

    public void ListUser()
    {
        UserManager UserFind = FindUser(IdFind);
        if (UserFind == null)
        {
            foreach (var user in UserList)
            {
                int userId = user.Key;
                User userInfo = user.Value;
                Console.WriteLine(userInfo.Name);
                Console.WriteLine(userInfo.Email);
                Console.WriteLine($"O seu id é: {userId}");
            }
        }
        else
        {
            if(UserList.TryGetValue(IdFind, out var user))
            {
                Console.WriteLine($"Usuario encontrado, seu nome é: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Id: {user.Id}");
            }
        }
    }

    public UserManager FindUser(int id)
    {
        if (!UserList.ContainsKey(id))
        {
            return null;
        }

        IdFind = id;
        return this;
    }

    public void RemoveUser(int id)
    {
        UserList.Remove(id);
    }
}