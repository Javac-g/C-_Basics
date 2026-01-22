public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsCheckedOut { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsCheckedOut = false;
    }

    public void CheckOut()
    {
        IsCheckedOut = true;
    }

    public void Return()
    {
        IsCheckedOut = false;
    }
}
