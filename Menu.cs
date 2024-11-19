using System.Numerics;
using static System.Console;
public class Menu
{
    Options Options = new Options();

    public Menu()
    {

    }
    public void Open()
    {
        Clear();
        WriteLine("A menu");
        Options.ListOptions();
    }
}