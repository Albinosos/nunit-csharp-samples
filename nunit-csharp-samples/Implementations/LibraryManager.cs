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
        if (!IsBookInLibrary(book))
        {
            // Додавання книги до колекції
            _books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" успішно додана до бібліотеки.");
        }
        else
        {
            Console.WriteLine($"Книга \"{book.Title}\" вже існує в бібліотеці.");
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
        // Перевірка на наявність книги в колекції
        if (library.Contains(book))
        {
            // Видалення книги з колекції
            library.Remove(book);
            Console.WriteLine($"Книга \"{book.Title}\" успішно видалена з бібліотеки.");
        }
        else
        {
            Console.WriteLine($"Книга \"{book.Title}\" не знайдена в бібліотеці.");
        }
    }
}