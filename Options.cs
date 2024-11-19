using static System.Console;
public class Options
{
    Dictionary<int, String> OptionList = new Dictionary<int, String>();
    public Options()
    {
        OptionList.Add(1,"List books");
        OptionList.Add(2,"Lend a book");
        OptionList.Add(3,"Add book");
    }
    public async void ListOptions(){
        foreach ((int Id, String Option) in OptionList)
        {
            WriteLine($"{Id} - {Option}");
        }
            awaitSelection(ReadKey());
    }
    public void awaitSelection(ConsoleKeyInfo Input){
        if(!char.IsDigit(Input.KeyChar))
        {
            WriteLine("Invalid key");
            ListOptions();
        }
            Clear();
            WriteLine("Running " + OptionList[int.Parse(Input.KeyChar.ToString())]);
        }
}