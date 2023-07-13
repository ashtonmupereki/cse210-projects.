using System;

class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    static void MainMenu()
    {
        Console.WriteLine("Welcome to the Student Enrollment System!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Enroll a student in a course");
        Console.WriteLine("2. View course roster");
        Console.WriteLine("3. Quit");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                // Enroll a student in a course
                EnrollStudent();
                break;
            case "2":
                // View course roster
                ViewRoster();
                break;
            case "3":
                // Quit
                Console.WriteLine("Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }

        MainMenu();
    }

    static void EnrollStudent()
    {
        // TODO: Implement student enrollment logic
        Console.WriteLine("Enrolling a student...");
    }

    static void ViewRoster()
    {
        // TODO: Implement course roster view logic
        Console.WriteLine("Viewing course roster...");
    }
}