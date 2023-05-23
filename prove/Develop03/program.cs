public class Program
{
    private static Scripture _scripture;

    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        _scripture = new Scripture(text, reference);

        Console.WriteLine(_scripture.GetRenderedText("reference"));
        Console.WriteLine(_scripture.GetRenderedText("visible"));

        _scripture.HideWords();

        Console.WriteLine(_scripture.GetRenderedText("hidden"));
    }
}
