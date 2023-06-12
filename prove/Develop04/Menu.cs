class Menu
{
    // Attributes
    private List<string> _menu = new List<string>()
    {
        "1. Start breathing activity",
        "2. Start reflecting activity",
        "3. Start listing activity",
        "4. Quit"
    };
    private string _userChoice;

    // Method to display the menu options
    public void DisplayMenu()
    {
        Console.WriteLine("Menu options");
        Console.WriteLine("Please select one of the following options:");
        foreach (string option in _menu)
        {
            Console.WriteLine(option);
        }
    }

    // Method to get user's choice from the menu
    public void GetUserChoice()
    {
        Console.Write("Select an option from the menu: ");
        _userChoice = Console.ReadLine();
    }
}
