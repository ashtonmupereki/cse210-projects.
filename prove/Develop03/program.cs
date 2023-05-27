using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Store a scripture
        Scripture john316 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Accommodate scriptures with multiple verses
        Scripture prov356 = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Clear console screen and display complete scripture
        Console.Clear();
        Console.WriteLine(john316.ToString());
        Console.WriteLine(prov356.ToString());

        // Prompt user to press enter key or type quit
        Console.WriteLine("\nPress Enter key to hide some words or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            // Hide a few random words in scripture
            john316.HideWords();
            prov356.HideWords();

            // Clear console screen and display complete scripture with hidden words
            Console.Clear();
            Console.WriteLine(john316.ToString());
            Console.WriteLine(prov356.ToString());

            // Prompt user to press enter key or type quit
            Console.WriteLine("\nPress Enter key to hide some more words or type 'quit' to exit.");
            input = Console.ReadLine();
        }
    }
}

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
