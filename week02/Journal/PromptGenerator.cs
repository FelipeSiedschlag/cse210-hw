public class PromptGenerator
{
    // List to store the prompts
    public List<string> _prompts = new List<string>();


    public PromptGenerator()
    {
        string fileName = "prompts.csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

        }
    }





    public string GetRandomPrompt()
    {

        // this is path to the csv file
        string filePath = "prompts.csv";

        // string[] is used to creat an array of string, this line reads the file
        string[] lines = System.IO.File.ReadAllLines(filePath);

        //Iterate over each line in the CSV file
        foreach (string line in lines)
        {
            // divide each line by the ,
            string[] sentence = line.Split(',');
            
            foreach (string part in sentence)
            {
                _prompts.Add(part);
            }
        }




        return "";
    }
}