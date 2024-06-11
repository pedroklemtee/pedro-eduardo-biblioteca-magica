using DesafioVortigoBiblioteca.Interfaces;

namespace DesafioVortigoBiblioteca;

public class LoanManager: ILoanManager
{
    private List<Loan> _loans = new List<Loan>();
    private LoanFindInfo loanFind;
    
    private class LoanFindInfo
    {
        public string Isbn { get; set; }
        public int UserId { get; set; }
    }

    public void RegisterLoan(Loan loan)
    {
        loan.LoanDate = DateTime.Now;
        _loans.Add(loan);
    }

    public void RegisterReturn(string isbn, int userId)
    {
        var loan = _loans.Find(loan => loan.Book.Isbn == isbn && loan.User.Id == userId);
            loan.ReturnDate = DateTime.UtcNow;
            Console.WriteLine($"Retorno do livro ISBN {isbn} do usuário ID {userId} registrado com sucesso.");
    }

    public void ListLoans()
    {
        if (loanFind == null)
        {
            Console.WriteLine("Lista de emprestimos:");
            foreach (var loan in _loans)
            {
                loan.DisplayDetails();
                Console.WriteLine($"Data de emprestimo: {loan.LoanDate.Date}");
                if (loan.ReturnDate != default(DateTime)) 
                {
                    Console.WriteLine($"Data de retorno: {loan.ReturnDate.Date}");
                }
                Console.WriteLine();
            }   
        }
        else
        {
            Console.WriteLine("O emprestimo localizado foi: ");
            foreach (var loan in _loans)
            {
                if (loan.Book.Isbn == loanFind.Isbn && loan.User.Id == loanFind.UserId)
                {
                    loan.DisplayDetails();
                    Console.WriteLine($"Data de emprestimo: {loan.LoanDate.Date}");
                    if (loan.ReturnDate != default(DateTime))
                    {
                        Console.WriteLine($"Data de retorno: {loan.ReturnDate.Date}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    public Loan FindLoan(string isbn, int userId)
    {
        loanFind = new LoanFindInfo{Isbn = isbn, UserId = userId};
        return _loans.Find(loan => loan.Book.Isbn == isbn && loan.User.Id == userId );
    }
    
}