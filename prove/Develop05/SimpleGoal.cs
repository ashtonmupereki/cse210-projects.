using System;

namespace MyNamespace
{
    public class SimpleGoal : Activity
    {
        private bool _completed;

        public SimpleGoal(string description, int points) : base("Simple Goal", points, description)
        {
            Console.Write("Enter the name of the goal: ");
            _activityName = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            _description = Console.ReadLine();
            Console.Write("Enter the number of points associated with this goal: ");
            _points = int.Parse(Console.ReadLine());
            _goals = "Simple Goal";
            _completed = false;
        }

        public string SimpleGoalName()
        {
            return _activityName;
        }

        public string SimpleGoalDescription()
        {
            return _description;
        }

        public bool IsCompleted()
        {
            return _completed;
        }

        public override void RecordActivity()
        {
            Console.WriteLine("Recording goal...");
            _completed = true;
        }
    }
}
