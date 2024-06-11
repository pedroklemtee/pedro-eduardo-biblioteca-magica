namespace DesafioVortigoBiblioteca;

public class Loan
{
    public User User { get;}
    public Book Book { get; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }

    public Loan(User user, Book book)
    {
        User = user;
        Book = book;
    }

    public void DisplayDetails()
    {
        User.DisplayDetail();
        Book.DisplayDetails();
    }
    
    
}