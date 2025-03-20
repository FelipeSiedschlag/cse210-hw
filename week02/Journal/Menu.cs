public class Menu
{
    public string _write;
    public string _display;
    public string _load;
    public string _save;
    public string _quit;


    public Journal _journal = new Journal();
    public PromptGenerator _promptGenerator = new PromptGenerator();

    public void Display()
    {

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                string prompt = _promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string userEntry = Console.ReadLine();

                Entry newEntry = new Entry(prompt, userEntry);
                _journal.AddEntry(newEntry);
                Console.WriteLine("Entry saved successfully!");
            }
            else if (input == 2)
            {
                _journal.DisplayAll();
            }
            else if (input == 3)
            {
                Console.Write("Enter filename to load (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                _journal.LoadFromFile(filename);
            }
            else if (input == 4)
            {
                Console.Write("Enter filename to save (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                _journal.SaveToFile(filename);
            }
            else if (input == 5)
            {
                Console.WriteLine("Exiting the program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option! Choose between 1 and 5.");
            }
        }
    }
}
        


