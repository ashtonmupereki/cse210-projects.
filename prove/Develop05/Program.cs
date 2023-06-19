using System;

namespace MyNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string choice = "";

            wellComeMessage();

            while (choice != "6")
            {
                menu.DisplayPoints();
                menu.DisplayChoices();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        menu.SubMenu();
                        string goalType = Console.ReadLine();

                        switch (goalType)
                        {
                            case "1":
                                SimpleGoal simpleGoal = new SimpleGoal();
                                menu.AddActivity(simpleGoal);
                                break;
                            case "2":
                                EternalGoal eternalGoal = new EternalGoal();
                                menu.AddActivity(eternalGoal);
                                break;
                            case "3":
                                CheckListGoal checkListGoal = new CheckListGoal();
                                menu.AddActivity(checkListGoal);
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;
                    case "2":
                        foreach (Activity activity in menu.GetActivities())
                        {
                            Console.WriteLine(activity.ActivityName() + " - " + activity.ActivityDescription() + " - " + activity.Points() + " points");
                        }
                        break;
                    case "3":
                        SaveGoals(menu.GetActivities());
                        break;
                    case "4":
                        LoadGoals(menu);
                        break;
                    case "5":
                        RecordEvent(menu);
                        break;
                    case "6":
                        EndingMessage();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void wellComeMessage()
        {
            Console.WriteLine("Welcome to the goal tracker program!");
        }

        static void EndingMessage()
        {
            Console.WriteLine("Thank you for using the goal tracker program!");
        }
    }
}
