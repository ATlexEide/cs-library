using static System.Console;
public class Options
{
    List<String> OptionList = new List<String>();
    public Options()
    {
        OptionList.Add("List books");
        OptionList.Add("Lend a book");
        OptionList.Add("Add book");
    }
    public void ListOptions(){
        foreach (String Option in OptionList)
        {
            WriteLine(Option);
        }
    }
}