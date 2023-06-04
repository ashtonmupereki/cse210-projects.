public class ListingActivity : Activity
{
    public override void Start()
    {
		Console.WriteLine("Welcome to Listing Activity.");
		Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
		Console.Write("How long in seconds would you like to do the session? ");
		int time = int.Parse(Console.ReadLine());
		Console.WriteLine("Get ready...");
		Console.WriteLine("List as many responses as you can for the following prompt:");
		Console.Write("\nWhen have you felt the Holy Ghost this month?\nYou may begin:\n");
		
		// simulate listing activity
		string prompt;
		int count = 0;
		do
		{
			prompt = Console.ReadLine();
			count++;
		} while (!string.IsNullOrEmpty(prompt));
		
		Console.WriteLine($"Well done! You listed {count - 1} responses.");
    }
}