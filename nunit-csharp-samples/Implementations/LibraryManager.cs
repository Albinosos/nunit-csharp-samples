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
        if (!IsBookInLibrary(book))
        {
            // ��������� ����� �� ��������
            _books.Add(book);
            Console.WriteLine($"����� \"{book.Title}\" ������ ������ �� ��������.");
        }
        else
        {
            Console.WriteLine($"����� \"{book.Title}\" ��� ���� � ��������.");
        }
    }

    /// <summary>
    /// Checks if the book is already in the library's collection.
    /// </summary>
    /// <param name="book">The book to check.</param>
    /// <returns>True if the book is in the collection, false otherwise.</returns>
    private bool IsBookInLibrary(Book book)
    {
        return _books.Contains(book);
    }


    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        // �������� �� �������� ����� � ��������
        if (library.Contains(book))
        {
            // ��������� ����� � ��������
            library.Remove(book);
            Console.WriteLine($"����� \"{book.Title}\" ������ �������� � ��������.");
        }
        else
        {
            Console.WriteLine($"����� \"{book.Title}\" �� �������� � ��������.");
        }
    }
}