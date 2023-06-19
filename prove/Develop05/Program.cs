using System;

namespace Ashton
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            Menu menu = new Menu(10);
            menu.DisplayPoints();
            menu.DisplayChoices();
            string choice = menu.GetChoices();

            while (choice != "6")
            {
                switch (choice)
                {
                    case "1":
                        menu.SubMenu();
                        break;
                    case "2":
                        Console.WriteLine("Listing goals...");
                        break;
                    case "3":
                        Console.WriteLine("Saving goals...");
                        break;
                    case "4":
                        Console.WriteLine("Loading goals...");
                        break;
                    case "5":
                        Console.WriteLine("Recording event...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                menu.DisplayChoices();
                choice = menu.GetChoices();
            }

            EndMessage();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static void EndMessage()
        {
            Console.WriteLine("Thank you for using the program!");
        }
    }
}
