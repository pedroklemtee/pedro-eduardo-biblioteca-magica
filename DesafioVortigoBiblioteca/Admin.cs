using System.ComponentModel.DataAnnotations;

namespace DesafioVortigoBiblioteca;

public class Admin:User
{
    private int AcessLevel { get; set; }

    public Admin(string name, string email, int id, int acessLevel) : base(name, email, id)
    {
        AcessLevel = acessLevel;
    }

    public override void DisplayDetail()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Email);
        Console.WriteLine(Id);
        Console.WriteLine(AcessLevel);
    }
}