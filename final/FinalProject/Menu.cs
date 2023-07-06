// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM

using System;
namespace Ashton
{

    public class Menu
    {
        public void Login()
        {
            //LOGIN DETAILS
            Console.WriteLine("Welcome to the Student Management System!\n");
            Console.WriteLine("Enter your name: ");
            Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            Console.ReadLine();
            Console.WriteLine("Enter your ID: ");
            int.Parse(Console.ReadLine());
        }

        //MAIN MENU OPTIONS
        public int ShowMainMenu()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Manage Courses");
            Console.WriteLine("2. Manage Grades");
            Console.WriteLine("3. Quit");
            return int.Parse(Console.ReadLine());
        }
        
        //STUDENT COURSE MENU
        public int ShowCourseMenu()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. View Courses");
            Console.WriteLine("2. Add Courses");
            Console.WriteLine("3. Drop Course");
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        //TEACHER COURSE MENU
        public int ShowTeachCourseMenu()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Course");
            Console.WriteLine("2. Remove Course");
            Console.WriteLine("3. Enroll a student in a course");
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        //STUDENT GRADE MENU
        public int ShowGradeMenu()
        {
            Console.WriteLine("\nChoose an Option:");
            Console.WriteLine("1. Enter Grades");
            Console.WriteLine("2. Calculate GPA");
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        public void ShowCourses(List<Course>courses)
        {
            Console.WriteLine("\nCourses:");
            foreach (Course course in courses)
            {
                Console.WriteLine($"Student id: {course.StudentID},Course ID: {course.CourseID}, Description: {course.Description}");
            }
        }

        //SELECT COURSE
        public int SelectCourse()
        {
            Console.WriteLine("Enter the Course ID: ");
            return int.Parse(Console.ReadLine());
        }

        public void ShowStudents(List<Student>students)
        {
            Console.WriteLine("\nStudents:");
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student},Name: {student}");
            }
        }

        public int SelectStudent()
        {
            Console.WriteLine("Enter the Student ID: ");
            return int.Parse(Console.ReadLine());
        }

        public void ShowGrades(List<Grade>grades)
        {
            Console.WriteLine("\nGrades:");
            foreach(Grade grade in grades)
            {
                Console.WriteLine($"Student ID: {grade.StudentID},Course ID: {grade.CourseID}, Vale: {grade.Value}");
            }
        }

        public void ShowGPA(float gpa)
        {
            Console.WriteLine($"\nGPA: {gpa}");
        }
    }
}