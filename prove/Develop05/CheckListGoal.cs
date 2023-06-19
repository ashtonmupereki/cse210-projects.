using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public class CheckListGoal : Activity
    {
        private List<string> _checklist;
        private bool _completed;

        public CheckListGoal(string description, int points) : base("CheckList Goal", points, description)
        {
            Console.Write("Enter the name of the goal: ");
            _activityName = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            _description = Console.ReadLine();
            Console.Write("Enter the number of points associated with this goal: ");
            _points = int.Parse(Console.ReadLine());
            _goalType = "Checklist Goal";
            _checklist = new List<string>();
            _completed = false;
        }

        public string ChecklistGoalName()
        {
            return _activityName;
        }

        public string ChecklistGoalDescription()
        {
            return _description;
        }

        public bool IsCompleted()
        {
            return _completed;
        }

        public void AddToChecklist(string item)
        {
            Console.WriteLine("Adding item to checklist...");
            _checklist.Add(item);
        }

        public void RemoveFromChecklist(string item)
        {
            Console.WriteLine("Removing item from checklist...");
            _checklist.Remove(item);
        }

        public void RecordGoal()
        {
            Console.WriteLine("Recording goal...");
            _completed = true;
        }
    }
}
