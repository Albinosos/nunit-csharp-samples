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
        // Перевірка на наявність книги в колекції
        if (!IsArticleInLibrary(book.Articul))
        {
            // Додавання книги до колекції
            _books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" успішно додана до бібліотеки.");
        }
        else
        {
            Console.WriteLine($"Книга з артикулом \"{book.Articul}\" вже існує в бібліотеці.");
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
            Console.WriteLine($"Книга \"{book.Title}\" успішно видалена з бібліотеки.");
        }
        else
        {
            Console.WriteLine($"Книга \"{book.Title}\" не знайдена в бібліотеці.");
        }
    }

    public List<Book> GetBooks()
    {
        return _books;
    }
}