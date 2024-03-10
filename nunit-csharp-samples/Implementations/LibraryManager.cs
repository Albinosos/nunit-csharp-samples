/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    /// <summary>
    /// Gets or sets a book articul.
    /// </summary>
    public string Articul { get; set; }

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        // �������� �� �������� ����� � ��������
        if (!IsArticleInLibrary(book.Articul))
        {
            // ��������� ����� �� ��������
            _books.Add(book);
            Console.WriteLine($"����� \"{book.Title}\" ������ ������ �� ��������.");
        }
        else
        {
            Console.WriteLine($"����� � ��������� \"{book.Articul}\" ��� ���� � ��������.");
        }
    }


    private bool IsArticleInLibrary(string article)
    {
        return _books.Any(book => book.Articul == article);
    }



    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        if (_books.Contains(book))
        {
            _books.Remove(book);
            Console.WriteLine($"����� \"{book.Title}\" ������ �������� � ��������.");
        }
        else
        {
            Console.WriteLine($"����� \"{book.Title}\" �� �������� � ��������.");
        }
    }

    public List<Book> GetBooks()
    {
        return _books;
    }
}