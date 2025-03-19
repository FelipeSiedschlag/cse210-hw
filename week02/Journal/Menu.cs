public class Menu
{
    public string _write;
    public string _display;
    public string _load;
    public string _save;
    public string _quit;

    public void Display()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}