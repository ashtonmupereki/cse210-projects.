using System;
using System.Collections.Generic;

namespace Ashton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some sample courses, students, and teachers
            Course course1 = new Course("Math", 101, "MATH101", "Introduction to Math", 3);
            Course course2 = new Course("English", 102, "ENGL102", "Introduction to English", 3);
            Course course3 = new Course("History", 103, "HIST103", "Introduction to History", 3);

            List<Course> courses = new List<Course>() { course1, course2, course3 };

            
            List<Student> students = new List<Student>();

            

            List<Teacher> teachers = new List<Teacher>();

            // Create and start the menu
            Menu menu = new Menu(courses, students, teachers);
            menu.Start();
        }
    }
}