public class Program
{
    private static List<Scripture> _scriptures;
    private static int _currentScriptureIndex;

    static void Main(string args)
    {
        _scriptures = new List<Scripture>();
        LoadScripturesFromFile("scriptures.txt");

        _currentScriptureIndex = 0;
        while (true)
        {
            Console.WriteLine(_scriptures[_currentScriptureIndex].GetRenderedText("visible"));
            Console.WriteLine($"Reference: {_scriptures[_currentScriptureIndex].Display()}");
            Console.Write("Press any key to hide a word, or 'q' to quit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }
            else
            {
                _scriptures[_currentScriptureIndex].HideWords();
            }
        }
    }

    static void LoadScripturesFromFile(string filePath)
    {
        string lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string parts = line.Split('|');
            string text = parts[0];
            string book = parts[1];
            int chapter = int.Parse(parts[2]);
            int startVerse = int.Parse(parts[3]);
            int endVerse = int.Parse(parts[4]);
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            Scripture scripture = new Scripture(text, reference);
            _scriptures.Add(scripture);
        }
    }
}
