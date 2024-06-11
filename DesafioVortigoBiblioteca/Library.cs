    namespace DesafioVortigoBiblioteca;

    public interface IBookManager
    {
        void AddBook(Book book);
        Book FindBook(string isbn);
        void RemoveBook(string isbn);
    }

    public class Library : IBookManager


    {
        private List<Book> booksList = new List<Book>();
        private string findedBook;

        public void AddBook(Book book)
        {
            booksList.Add(book);
        }

        public void RemoveBook(string isbn)
        {   
            var bookToRemove = FindBook(isbn);
            if (bookToRemove != null)
            {
                booksList.Remove(bookToRemove);
            }
        }

            public Book FindBook(string isbn = null)
            {
                findedBook = isbn;
                if (isbn == null)
                {
                    return null;
                }
                return booksList.Find(book => book.Isbn == isbn);
            }
    
        public void ListBooks()
        {
             var bookFound = FindBook(findedBook);
            if (bookFound == null)
            {
                foreach (var book in booksList)
                {
                    book.DisplayDetails();
                    Console.WriteLine();
                }
            }
            else
            {
                 bookFound.DisplayDetails();
            }
        }
    }