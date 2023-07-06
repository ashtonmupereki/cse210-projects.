// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM

using System;
namespace Ashton
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREATE THE MENU
            Menu menu = new Menu();

            List<Course> courses = new List<Course>();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Grade> grades = new List<Grade>();
            List<Enrollment> enrollments = new List<Enrollment>();
            List<Department> departments = new List<Department>();
            menu.Login();

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("Login successful!");

            menu.ShowMainMenu();

        }
    }
}