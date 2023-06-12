class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness activity program!");

        Menu menu = new Menu();
        menu.DisplayMenu();
        menu.GetUserChoice();

        Console.WriteLine("Thank you for using the activity program!");
    }
}
