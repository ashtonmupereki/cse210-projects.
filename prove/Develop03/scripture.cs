using System;

class Scripture
{
    private string reference;
    private string text;
    private List<string> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = new List<string>(text.Split(' '));
    }

    public void HideWords()
    {
        Random rand = new Random();
        int numWordsToHide = rand.Next(1, words.Count / 2);

        for (int i = 0; i < numWordsToHide; i++)
        {
            int index = rand.Next(words.Count);
            words[index] = new string('_', words[index].Length);
        }
    }

    public override string ToString()
    {
        return $"{reference}: {string.Join(' ', words)}";
    }
}
