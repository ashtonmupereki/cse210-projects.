using System;

namespace Ashton
{
    public class Menu
    {
        private string _choices;
        private int _points;

        public Menu(int points)
        {
            _points = points;
        }

        public void DisplayPoints()
        {
            Console.WriteLine($"You have {_points} points.");
        }

        public void DisplayChoices()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
        }

        public string GetChoices()
        {
            return _choices;
        }

        public void SubMenu()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple goals");
            Console.WriteLine("2. Eternal goals");
            Console.WriteLine("3. Check list goals");
            Console.Write("Which type of goal do you want to create?: ");
        }

        public void GetScore()
        {
            Console.WriteLine("Getting score...");
        }
    }
}
