using DesafioVortigoBiblioteca;

Library library = new Library();
    
Book newBook = new Book("A dama", "O damo", "123-456", 12);
Book newBook2 = new Book("A damo", "O dama", "124-457", 13);
Book newBook3 = new Book("A dame", "O daml", "124-458", 13);

library.AddBook(newBook);
library.AddBook(newBook2);
library.AddBook(newBook3);
library.FindBook("124-458");

UserManager usersInfo = new UserManager();
User newUser = new User("Pedroca", "pedroca.com", 3);
User newUser2 = new User("Pedrocinha", "pedroca.com.br", 4);
usersInfo.AddUser("Pedro", "pedro.gmail", 1);
usersInfo.AddUser("Pedrin", "pedro.gmaildd", 2);
usersInfo.RemoveUser(1);
Console.WriteLine();

Loan newLoan = new Loan(newUser, newBook);
Loan newLoan2 = new Loan(newUser2, newBook2);
LoanManager newLoanManager = new LoanManager();
newLoanManager.RegisterLoan(newLoan);
newLoanManager.RegisterLoan(newLoan2);

Console.WriteLine("Lista de loans: ");
newLoanManager.ListLoans();
Console.WriteLine("Lista filtrada: ");
newLoanManager.FindLoan(newLoan2.Book.Isbn, newLoan2.User.Id);
newLoanManager.ListLoans();
Console.WriteLine();
newLoanManager.RegisterReturn(newLoan2.Book.Isbn, newLoan2.User.Id);
newLoanManager.ListLoans();