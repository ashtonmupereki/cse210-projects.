using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            while (true)
            {
                Console.WriteLine("1. Add entry");
                Console.WriteLine("2. Display entries");
                Console.WriteLine("3. Save entries to file");
                Console.WriteLine("4. Load entries from file");
                Console.WriteLine("5. Generate prompt");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter prompt: ");
                        string prompt = Console.ReadLine();
                        Console.Write("Enter response: ");
                        string response = Console.ReadLine();
                        Entry entry = new Entry(prompt, response, DateTime.Now);
                        journal.AddEntry(entry);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter file name: ");
                        string fileName = Console.ReadLine();
                        journal.SaveToFile(fileName);
                        break;
                    case "4":
                        Console.Write("Enter file name: ");
                        fileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                        break;
                    case "5":
                        string randomPrompt = promptGenerator.GeneratePrompt();
                        Console.WriteLine(randomPrompt);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
