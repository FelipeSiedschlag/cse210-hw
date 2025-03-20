public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public Entry(string prompt, string entryText)
    {
        _date = DateTime.Now.ToString("MM-dd-yyyy");
        _promptText = prompt;
        _entryText = entryText;
    }


    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}