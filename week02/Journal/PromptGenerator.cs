using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        string filename = "prompts.csv";

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                
                string[] parts = line.Split(",");

                
                foreach (string part in parts)
                {
                    string trimmedPart = part.Trim(); 
                    if (!string.IsNullOrWhiteSpace(trimmedPart)) 
                    {
                        _prompts.Add(trimmedPart);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filename);
        }
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
            return "No phrases available.";

        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}

