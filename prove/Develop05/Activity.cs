using System;

namespace MyNamespace
{
    public class Activity
    {
        protected string _goals;
        protected int _points;
        protected int _score;
        protected string _description;
        protected string _activityName;

        public Activity(string goals, int points, string description)
        {
            _goals = goals;
            _points = points;
            _description = description;
            _activityName = "Activity";
        }

        public virtual void Run()
        {
            Console.WriteLine("Running activity...");
        }

        public virtual void AddActivity()
        {
            Console.WriteLine("Adding activity...");
        }

        public virtual void RecordActivity()
        {
            Console.WriteLine("Recording activity...");
        }

        public virtual void DisplayActivities()
        {
            Console.WriteLine("Displaying activities...");
        }

        public virtual void DisplayScore()
        {
            Console.WriteLine("Displaying score...");
        }

        public virtual void LoadActivities()
        {
            Console.WriteLine("Loading activities...");
        }
    }
}
