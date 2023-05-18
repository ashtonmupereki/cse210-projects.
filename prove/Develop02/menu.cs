class Menu
{
 private Journal journal;
 private PromptGenerator promptGenerator;

 public Menu()
 {
 journal = new Journal();
 promptGenerator = new PromptGenerator();
 }

 public void Run()
 {
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
 string prompt = promptGenerator.GeneratePrompt();
 string response = Console.ReadLine();
 Entry entry = new Entry(prompt, response, DateTime.Now);
 journal.AddEntry(entry);
 break;
 case "2":
 journal.DisplayEntries();
 break;
 case "3":
 journal.SaveToFile("filename.txt");
 break;
 case "4":
 journal.LoadFromFile("filename.txt");
 break;
 case "5":
 string newPrompt = promptGenerator.GeneratePrompt();
 Console.WriteLine(newPrompt);
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
