using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 17);
        Console.WriteLine("Reference: {0} {1}:{2}-{3}", reference.Book, reference.Chapter, reference.StartVerse, reference.EndVerse);

        Scripture scripture = new Scripture("John 3:16-17", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God did not send his Son into the world to condemn the world, but to save the world through him.");
        Console.WriteLine("Scripture: {0} - {1}", scripture.Reference, scripture.Text);

        Word word = new Word("Hello");
        Console.WriteLine("Word: {0}", word.Text);
    }
}
