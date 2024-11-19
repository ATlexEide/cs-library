namespace cs_library;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Pick a name for your library");
        Library UserLibrary = new Library(ReadLine());
        WriteLine($"{UserLibrary.Name} is ready");
    }
}
