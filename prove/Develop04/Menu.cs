public class Menu : Activity
{
	public override void Start()
	{
	    while (true)
	    {
	        Console.Clear();
	        Console.WriteLine("Please choose an option:");
	        Console.WriteLine("1. Breathing Activity");
	        Console.WriteLine("2. Reflecting Activity");
	        Console.WriteLine("3. Listing Activity");
	        Console.WriteLine("4. Quit");
	        int choice = int.Parse(Console.ReadLine());
	        switch (choice)
	        {
	            case 1:
	                new BreathingActivity().Start();
	                break;
	            case 2:
	                new ReflectingActivity().Start();
	                break;
	            case 3:
	                new ListingActivity().Start();
	                break;
	            case 4:
	                return;
	            default:
	                break;
	        }
	        // wait for user input before returning to menu
	        if (choice != 4)
	        {
	            Console.Write("\nPress any key to continue...");
	            Console.ReadKey();
	        }
	    }
	}
}
