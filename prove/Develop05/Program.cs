using System;

namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the goal tracking program!");

            Menu menu = new Menu();
            menu.Run();

            int totalPoints = 0;
            foreach (var goal in menu._goals)
            {
                if (goal.IsCompleted())
                {
                    totalPoints += goal._points;
                }
            }

            Console.WriteLine($"Congratulations! You scored {totalPoints} points.");

            Console.WriteLine("Thank you for using the goal tracking program. Goodbye!");
        }
    }
}