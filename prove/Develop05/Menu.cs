using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public class Menu
    {
        private int _points;
        private List<string> _choices;
        private List<string> _activities;

        public Menu(int points, List<string> choices, List<string> activities)
        {
            _points = points;
            _choices = choices;
            _activities = activities;
        }

        public void DisplayPoints()
        {
            Console.WriteLine($"Points: {_points}");
        }

        public void DisplayChoices()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4.Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            
            for (int i = 0; i < _choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_choices[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SubMenu();
                    break;
                case 2:
                    // List goals
                    break;
                case 3:
                    // Save goals
                    break;
                case 4:
                    // Load goals
                    break;
                case 5:
                    // Record event
                    break;
                case 6:
                    // Quit
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void SubMenu()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple goals");
            Console.WriteLine("2. Eternal goals");
            Console.WriteLine("3. Check list goals");
            Console.Write("Which type of goal do you want to create?: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // Create new simple goal
                    break;
                case 2:
                    // Create new eternal goal
                    break;
                case 3:
                    // Create new checklist goal
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
