using NUnit.Framework;

namespace nunit_csharp_samples.Tests
{
    public class LibraryManagerTests
    {
        // TODO step 4.

        [Test]
        public void TestAddBook()
        {
            // Arrange
            var libraryManager = new LibraryManager();
            var bookToAdd = new Book { Title = "Book1", Author = "Author1", Articul = "123" };

            // Act
            libraryManager.AddBook(bookToAdd);

            // Assert
            Assert.That(libraryManager.GetBooks(), Has.Count.EqualTo(1));
            Assert.That(libraryManager.GetBooks()[0], Is.EqualTo(bookToAdd));
        }

        [Test]
        public void TestRemoveBook()
        {
            // Arrange
            var libraryManager = new LibraryManager();
            var bookToRemove = new Book { Title = "Book1", Author = "Author1", Articul = "123" };
            libraryManager.AddBook(bookToRemove);

            // Act
            libraryManager.RemoveBook(bookToRemove);

            // Assert
            Assert.That(libraryManager.GetBooks(), Has.Count.EqualTo(0));
        }
    }
}
