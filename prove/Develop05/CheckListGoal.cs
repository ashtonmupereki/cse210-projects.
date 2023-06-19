using System;

namespace Ashton
{
    public class CheckListGoal : Activity
    {
        private bool _completed;
        private int _bonus;
        private int _timesToAccomplish;

        public CheckListGoal(string goalType, int points) : base(goalType, points)
        {
            _activityName = "Checklist Goal";
            Console.Write("Enter the name of the goal: ");
            _description = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            _description += " - " + Console.ReadLine();
            Console.Write("Enter the number of points associated with this goal: ");
            _points = int.Parse(Console.ReadLine());
            Console.Write("Enter how many times this goal needs to be accomplished for a bonus: ");
            _timesToAccomplish = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus for accomplishing it that many times: ");
            _bonus = int.Parse(Console.ReadLine());
        }

        public void CheckListGoalName()
        {
            Console.WriteLine("Checklist Goal");
        }

        public void CheckListGoalDescription()
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
