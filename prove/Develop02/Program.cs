
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Add a new prompt");
            Console.WriteLine(" 7. What do you want to say?");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add an entry
                    break;
                case "2":
                    // Display all entries
                    break;
                case "3":
                    // Save to a file
                    break;
                case "4":
                    // Load from a file
                    break;
                case "5":
                    // Exit the program
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}