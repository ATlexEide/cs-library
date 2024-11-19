namespace cs_library;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Library UserLibrary = new Library();
        UserLibrary.Init();
        UserLibrary.Menu.Open();
    }
}
