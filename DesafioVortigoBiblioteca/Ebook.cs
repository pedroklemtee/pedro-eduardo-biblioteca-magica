using System.Reflection;

namespace DesafioVortigoBiblioteca;

public class Ebook:Book
{
    public int FileSize { get; set; }
    public string FileFormat { get; set; }

    
    public Ebook(string title, string author, string isbn, int publishYear, int fileSize, string fileFormat) : base(title, author, isbn, publishYear)
    {
        FileSize = fileSize;
        FileFormat = fileFormat;
    }

    public override void DisplayDetails()
    {
            Console.WriteLine($"Titulo: {Title}");
            Console.WriteLine($"Autor: {Author}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine($"Ano de publicação: {PublishYear}");
            Console.WriteLine($"Tamanho do arquivo: {FileSize}");
            Console.WriteLine($"Formato do arquivo: {FileFormat}");
    }
}