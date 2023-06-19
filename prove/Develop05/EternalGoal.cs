using System;

namespace Ashton
{
    public class EternalGoal : Activity
    {
        private bool _completed;

        public EternalGoal(string goalType, int points) : base(goalType, points)
        {
            _activityName = "Simple Goal";
            Console.Write("Enter the name of the goal: ");
            _description = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            _description += " - " + Console.ReadLine();
            Console.Write("Enter the number of points associated with this goal: ");
            _points = int.Parse(Console.ReadLine());
        }

        public void SimpleGoalName()
        {
            Console.WriteLine("Simple Goal");
        }

        public void SimpleGoalDescription()
        {
            Console.WriteLine(_description);
        }
        public bool IsCompleted()
        {
            return _completed;
        }

        public void RecordGoal()
        {
            Console.WriteLine("Recording goal...");
        }
    }
}
