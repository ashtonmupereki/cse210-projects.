using System;

namespace MyNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the goal tracker program!");

            Menu menu = new Menu();
            menu.DisplayChoices();
            menu.GetChoices();

            
            Console.WriteLine("Thank you for using the goal tracker program!");
                        
        }
    }
}
    

