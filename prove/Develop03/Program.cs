using System;

class Program
{
 static void Main(string[] args)
 {
 Reference reference = new Reference("John", 3, 16, 17);
 Scripture scripture = new Scripture("John 3:16-17", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God did not send his Son into the world to condemn the world, but to save the world through him.");

 Console.WriteLine("Reference: {0} {1}:{2}-{3}", reference._book, reference._chapter, reference._startVerse, reference._endVerse);
 Console.WriteLine("Scripture: {0} - {1}", scripture._reference, scripture._text);

 Console.WriteLine("Press Enter to continue... or type quit to finish");
 while (Console.ReadKey().Key != ConsoleKey.Enter) { }

 string[] words = scripture._text.Split(' ');
 int index = 0;
 while (index < words.Length)
 {
 Console.Write("Enter to hide next three words: ");
 Console.ReadLine();
 for (int i = index; i < index + 3 && i < words.Length; i++)
 {
 words[i] = new string('_', words[i].Length);
 }
 Console.WriteLine(string.Join(" ", words));
 index += 3;
 }

 Console.WriteLine("Press Enter to quit...");
 while (Console.ReadKey().Key != ConsoleKey.Enter) { }
 Environment.Exit(0);
 }
}
