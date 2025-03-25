using Microsoft.VisualBasic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
    }

    public void HideRamdomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;

        while (count < numberToHide)
        {
            int index = random.Next(_words.Count); // generate a random index
            Word word = _words[index];
            if (!word.IsHidden())
            {
                word.Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        return
    }

    public bool IsCompletelyHidden()
    {
        
    }
}