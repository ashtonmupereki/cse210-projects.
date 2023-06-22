using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public class EternalQuestProgram
    {
        private int _points;
        private List<string> _choices;
        private List<string> _activities;

        public EternalQuestProgram(int points, List<string> choices, List<string> activities)
        {
            _points = points;
            _choices = choices;
            _activities = activities;
        }

        public void DisplayPoints()
        {
            Console.WriteLine("Welcome to the goal tracker program!");
            Console.WriteLine($"Points: {_points}");
        }

        public void DisplayActivities()
        {
            Console.WriteLine($"Goals: {_activities}");
        }

        public void DisplayChoices()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create a new goal.");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals ");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit.");
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
                    List<Activity> goals = new List<Activity>();

                    // Add some goals to the list
                    goals.Add(new SimpleGoal("Goal 1", 10));
                    goals.Add(new EternalGoal("Goal 2", 20));
                    goals.Add(new CheckListGoal("Goal 3", 30));

                    // Loop through the goals and display information about each goal
                    foreach (Activity goal in goals)
                    {
                        goal.DisplayActivities();
                    }
                    
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
            Console.WriteLine("Which type of goal do you want to create?:");
            Console.WriteLine("1. Simple goals");
            Console.WriteLine("2. Eternal goals");
            Console.WriteLine("3. Check list goals");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // Create new simple goal
                    Console.Write("Enter the name of the goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the description of the goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the number of points associated with this goal: ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal simpleGoal = new SimpleGoal(name, points);

                    DisplayActivities();

                    Thread.Sleep(7000);
                    Console.WriteLine("Thank you for using the goal tracker program. Press enter to return to the menu!");
                    while (true)
                    {
                        DisplayChoices();
                    
                    }
                    
                case 2:
                    // Create new eternal goal
                    Console.Write("Enter the name of the goal: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Enter the description of the goal: ");
                    string description2 = Console.ReadLine();
                    Console.Write("Enter the number of points associated with this goal: ");
                    int points2 = int.Parse(Console.ReadLine());
                    EternalGoal eternalgoal = new EternalGoal(name1, points2);

                    DisplayActivities();

                    Thread.Sleep(7000);
                    Console.WriteLine("Thank you for using the goal tracker program. Press enter to return to the menu!");
                    while (true)
                    {
                        DisplayChoices();
                    
                    }
                    
                
                case 3:
                    // Create new checklist goal
                    Console.Write("Enter the name of the goal: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Enter the description of the goal: ");
                    string description3 = Console.ReadLine();
                    Console.Write("Enter the number of points associated with this goal: ");
                    int points3 = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                    int numbeOfrTimes = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times?  ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    CheckListGoal checklistgoal = new CheckListGoal(name2, points3);

                    DisplayActivities();

                    Thread.Sleep(7000);
                    Console.WriteLine("Thank you for using the goal tracker program. Press enter to return to the menu!");
                    while (true)
                    {
                        DisplayChoices();
                    
                    }
                    
                    
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            var eternalQuestProgram = new EternalQuestProgram(0, new List<string>(), new List<string>());
            eternalQuestProgram.DisplayPoints();
            eternalQuestProgram.DisplayActivities();
            eternalQuestProgram.DisplayChoices();
        }
    }
}
