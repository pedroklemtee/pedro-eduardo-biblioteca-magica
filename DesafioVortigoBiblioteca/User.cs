namespace DesafioVortigoBiblioteca;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Id { get; set; }
    
    public User(string name, string email, int id)
    {
        Name = name;
        Email = email;
        Id = id;
    }

    public virtual void DisplayDetail()
    {
        Console.WriteLine($"Nome de usuario: {Name}");
        Console.WriteLine($"Email de usuario: {Email}");
        Console.WriteLine($"Id de usuario: {Id}");
        Console.WriteLine();
    }
}