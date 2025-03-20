public class Journal
{


    List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }

        Console.WriteLine("\nJournal Entries:\n");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // open text to write
        StreamWriter writer = new StreamWriter(file);

        foreach (Entry entry in _entries)
        {
            // Save date, promptText and entryText
            writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }

        writer.Close();  // Closes the file
        Console.WriteLine("Journal saved successfully.");
    }


    public void LoadFromFile(string file)
    {
        if (File.Exists(file))  // Check the file
        {
            _entries.Clear();  // Clean the existing entries

            string[] lines = File.ReadAllLines(file); 
            foreach (string line in lines)
            {
                string[] parts = line.Split(','); 

                if (parts.Length == 3)
                {
                    
                    Entry newEntry = new Entry(parts[1], parts[2])
                    {
                        _date = parts[0] 
                    };
                    _entries.Add(newEntry);
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}