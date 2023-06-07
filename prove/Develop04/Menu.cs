class Menu
{
    private string _choice;

    public void DisplayMenu()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }

    public void MenuItem()
    {
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
                Console.WriteLine("Thank you for using the Breathing Activity Program!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                break;
            default:
                break;
        }
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Breathing Activity Program!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        while (true)
        {
            Console.Clear();
            DisplayMenu();
            MenuItem();

            // wait for user input before returning to menu
            if (_choice != "4")
            {
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nThank you for using the Breathing Activity Program!");
                return;
            }
        }
    }
}
