using static System.Console;

public class Library
{
    public String Name;
    public static BookList BookList = new BookList();
    public Menu Menu = new Menu();
    public Library()
    {
        Clear();
        WriteLine("Pick a name for your library");
        Name = ReadLine();
    }
    public void Init()
    {
        Clear();
        WriteLine($"{Name} is ready");
        ReadKey();
        Menu.Open();
    }
}
