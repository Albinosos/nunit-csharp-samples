/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        // Перевірка на наявність книги в колекції
        if (!library.Contains(book))
        {
            // Додавання книги до колекції
            library.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" успішно додана до бібліотеки.");
        }
        else
        {
            Console.WriteLine($"Книга \"{book.Title}\" вже існує в бібліотеці.");
        }
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