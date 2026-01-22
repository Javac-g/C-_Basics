using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book? FindBookByTitle(string title)
    {
        return books.FirstOrDefault(b => b.Title == title);
    }

    public List<Book> GetAvailableBooks()
    {
        return books.Where(b => !b.IsCheckedOut).ToList();
    }
}
