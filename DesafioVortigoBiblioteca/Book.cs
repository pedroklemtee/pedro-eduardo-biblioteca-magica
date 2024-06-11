    using System.Diagnostics.SymbolStore;
    using System.Reflection;

    namespace DesafioVortigoBiblioteca;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int PublishYear { get; set; }

        public Book(string title, string author, string isbn, int publishYear)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            PublishYear = publishYear;
        }

        public virtual void DisplayDetails()
        {
                Console.WriteLine($"Titulo: {Title}");
                Console.WriteLine($"Autor: {Author}");
                Console.WriteLine($"ISBN: {Isbn}");
                Console.WriteLine($"Ano de publicação: {PublishYear}");
                Console.WriteLine();
        }
    }