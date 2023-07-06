// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM

using System;
namespace Ashton
{

public class Student: Person
    {
        private string _name;
        private string _address;
        private string _email;
        private int _id;
        private bool _status;

        
        public Student(string name, string address, string email, int id): base(name, address, email, id)
        {
            _name = name;
            _address = address;
            _id = id;
            _email = email;
            _status = true;
        }

        public Student(string name, string address, string email, int id, bool status): base(name, address, email, id)
        {
            _status = status;
        }

        public Boolean isCompleted()
        {
            return _status;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            return ;
        }
    }
}