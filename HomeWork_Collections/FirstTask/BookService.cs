using System.Collections;

namespace HomeWork_Collections.FirstTask;

public static class BookService
{
    public static void PrintBooks(ArrayList booksList)
    {
        for (var i = 0; i < booksList.Count; i++)
        {
            Book book = (Book)booksList[i];
            Console.WriteLine($"{i + 1} Автор {book.Author}, название \"{book.Name}\", год издания {book.Year}");
        }
    }

    public static void FindBook(ArrayList booksList, string author)
    {
        ArrayList foundBooks;
        foundBooks = new ArrayList();

        foreach (Book book in booksList)
        {
            if (author.Equals(book.Author))
            {
                foundBooks.Add(book);
            }
        }

        if (foundBooks.Count > 0)
        {
            foreach (Book fBook in foundBooks)
            {
                Console.WriteLine(
                    $"В нашей библиотеке от автора {author} есть книга \"{fBook.Name}\", год издания {fBook.Year}");
            }
        }
        else
        {
            Console.WriteLine($"В нашей библиотеке нет книг автора {author}");
        }
    }
}