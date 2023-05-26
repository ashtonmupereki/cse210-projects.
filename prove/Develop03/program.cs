class Program
{
    static void Main(string args)
    {
        // create a new reference object
        Reference reference = new Reference("John", 3, 16);

        // create a new scripture object
        Scripture scripture = new Scripture("For God so loved the world...", reference);

        // print the reference and rendered text
        Console.WriteLine(scripture.Reference.Display());
        Console.WriteLine(scripture.GetRenderedText("HTML"));
    }
}