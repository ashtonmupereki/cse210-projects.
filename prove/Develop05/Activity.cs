using System;

namespace Ashton
{
    public class Activity
    {
        protected string _goalType;
        protected int _points;
        protected int _score;
        protected string _description;
        protected string _activityName;

        public Activity(string goalType, int points, string description)
        {
            _goalType = goalType;
            _points = points;
            _description = description;
        }

        public void Run()
        {
            Console.WriteLine("Running...");
        }

        public void Save()
        {
            Console.WriteLine("Saving...");
        }

        public void AddActivity()
        {
            Console.WriteLine("Adding activity...");
        }

        public void RecordActivity()
        {
            Console.WriteLine("Recording activity...");
        }

        public void DisplayActivities()
        {
            Console.WriteLine("Displaying activities...");
        }

        public void DisplayScore()
        {
            Console.WriteLine("Displaying score...");
        }

        public void LoadActivities()
        {
            Console.WriteLine("Loading activities...");
        }
    }
}
