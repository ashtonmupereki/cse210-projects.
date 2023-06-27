using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public class Menu
    {
        private List<Activity> _goals;

        public Menu()
        {
            _goals = new List<Activity>();
        }

        public void Run()
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Menu options:");
                Console.WriteLine("1. Create a new goal.");
                Console.WriteLine("2. List goals.");
                Console.WriteLine("3. Save goals.");
                Console.WriteLine("4. Load goals.");
                Console.WriteLine("5. Record event.");
                Console.WriteLine("6. Quit.");

                Console.Write("Select a choice from the menu: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoals();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("What type of goal do you want to create?");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter a description for the simple goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the number of points for the simple goal: ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal simpleGoal = new SimpleGoal(description, points);
                    _goals.Add(simpleGoal);
                    Console.WriteLine("Simple goal created successfully.");
                    break;
                case "2":
                    Console.Write("Enter a description for the eternal goal: ");
                    description = Console.ReadLine();
                    Console.Write("Enter the number of points for the eternal goal: ");
                    points = int.Parse(Console.ReadLine());
                    EternalGoal eternalGoal = new EternalGoal(description, points);
                    _goals.Add(eternalGoal);
                    Console.WriteLine("Eternal goal created successfully.");
                    break;
                case "3":
                    Console.Write("Enter a description for the checklist goal: ");
                    description = Console.ReadLine();
                    Console.Write("Enter the number of points for the checklist goal: ");
                    points = int.Parse(Console.ReadLine());
                    CheckListGoal checklistGoal = new CheckListGoal(description, points);
                    _goals.Add(checklistGoal);
                    Console.WriteLine("Checklist goal created successfully.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        private void ListGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to display.");
                return;
            }

            foreach (var goal in _goals)
            {
                Console.WriteLine("--------------------------------");
                goal.DisplayActivities();
            }
        }

        private void SaveGoals()
        {
            // TODO: Implement saving of goals to a file.
            Console.WriteLine("Saving goals...");
        }

        private void LoadGoals()
        {
            // TODO: Implement loading of goals from a file.
            Console.WriteLine("Loading goals...");
        }

        private void RecordEvent()
        {
            Console.Write("Enter the name of the goal to record an event for: ");
            string goalName = Console.ReadLine();

            Activity goal = _goals.Find(g => g._activityName == goalName);

            if (goal == null)
            {
                Console.WriteLine("Goal not found.");
                return;
            }

            goal.RecordActivity();
            Console.WriteLine("Event recorded successfully.");
        }
    }
}