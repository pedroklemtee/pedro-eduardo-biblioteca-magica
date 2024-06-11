namespace DesafioVortigoBiblioteca.Interfaces;

public interface ILoanManager
{
        public void RegisterLoan(Loan loan);
        public void RegisterReturn(string isbn, int userId);
        public void ListLoans();
        public Loan FindLoan(string isbn, int userId);
}