using NUnit.Framework;

namespace nunit_csharp_samples.Tests
{
    public class LibraryStatisticsAnalyzerTests
    {
        // TODO step 4.

        [Test]
        public void TestGetBooksByAuthor()
        {
            // Arrange
            var libraryManager = new LibraryManager();
            var analyzer = new LibraryStatisticsAnalyzer(libraryManager);
            var author = "Author1";
            var expectedBook = new Book { Title = "Book1", Author = author, Articul = "123" };

            // Act
            libraryManager.AddBook(expectedBook);
            var result = analyzer.GetBooksByAuthor(author);

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0], Is.EqualTo(expectedBook));
        }
    }
}
