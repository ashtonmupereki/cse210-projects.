using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("John", 3, 16, 17);
            Scripture scripture = new Scripture("John 3:16-17", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God did not send his Son into the world to condemn the world, but to save the world through him.");

            Console.WriteLine("Reference: {0} {1}:{2}-{3}", reference._book, reference._chapter, reference._startVerse, reference._endVerse);
            Console.WriteLine("Scripture: {0} - {1}", scripture._reference, scripture._text);

            string[] words = scripture._text.Split(' ');
            int index = 0;
            Random random = new Random();
            while (true)
            {
                Console.Write("Press Enter to continue or type quit to finish: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                for (int i = index; i < words.Length; i += 3)
                {
                    if (random.Next(2) == 0 && i + 2 < words.Length)
                    {
                        words[i] = new string('_', words[i].Length);
                        words[i + 1] = new string('_', words[i + 1].Length);
                        words[i + 2] = new string('_', words[i + 2].Length);
                    }
                }
                Console.WriteLine(string.Join(" ", words));
                index += 3;
            }

            Console.WriteLine("Press Enter to quit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Environment.Exit(0);
        }
    }
}
