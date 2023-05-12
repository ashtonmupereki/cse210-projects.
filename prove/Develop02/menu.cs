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
            // Add entry
            break;
        case "2":
            // Display entries
            break;
        case "3":
            // Save entries to file
            break;
        case "4":
            // Load entries from file
            break;
        case "5":
            // Generate prompt
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}
