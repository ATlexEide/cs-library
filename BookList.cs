using static System.Console;
public class BookList
{
    List<Book> List = new List<Book>();
    
    public BookList()
    {
        addPlaceholderBooks();
    }
    public void ListBooks()
    {
        foreach (Book Book in List)
        {
            WriteLine($"{Book.Title} by {Book.Author}, {Book.Pages} pages");
        }
    }
    public void addPlaceholderBooks()
    {
        List.Add(new Book("My test-book", "Alex", 420));
        List.Add(new Book("Recursive Loops", "Lars", 28493));
        List.Add(new Book("Heccern", "Hecc", 1));
    }
}