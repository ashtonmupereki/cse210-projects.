using System;

namespace MyNamespace
{
    public class EternalGoal : Activity
    {
        private bool _completed;

        public EternalGoal(string description, int points) : base("Eternal Goal", points, description)
        {
            Console.Write("Enter the name of the goal: ");
            _activityName = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            _description = Console.ReadLine();
            Console.Write("Enter the number of points associated with this goal: ");
            _points = int.Parse(Console.ReadLine());
            _goalType = "Simple Goal";
            _completed = false;
        }

        public string EternalGoalName()
        {
            return _activityName;
        }

        public string EternalGoalDescription()
        {
            return _description;
        }

        public bool IsCompleted()
        {
            return _completed;
        }

        public void RecordGoal()
        {
            Console.WriteLine("Recording goal...");
            _completed = true;
        }

        public override void DisplayActivities()
        {
            base.DisplayActivities();
            Console.WriteLine($"Activity type: {_goalType}");
            Console.WriteLine($"Activity status: {(_completed ? "Completed" : "Incomplete")}");
        }
    }
}
