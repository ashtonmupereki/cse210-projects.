// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM

using System;
namespace Ashton
{
    //ATTRIBUTES
    public abstract class Person
    {
        private string _name;
        private string _address;
        private string _email;
        private int _id;

        public Person(string name,string address, string email, int id)
        {
            _name = name;
            _address = address;
            _email = email;
            _id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.Write("Name: "+ _name);
            Console.Write("Address: "+ _address);
            Console.Write("Email: "+ _email);
            Console.Write("ID: "+ _id);
        }

    }
}