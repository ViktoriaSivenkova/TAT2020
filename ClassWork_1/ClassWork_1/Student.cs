using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassWork_1
{
    public class Student : ITaskPerfomer
    {
        string _firstName;
        string _lastName;
        const int STRINGLENGTH = 15;

        public Student (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => _firstName;
            private set 
            {
                _firstName = value;            
            }

        }

        public string LastName
        {
            get => _lastName;
            private set 
            {
                _lastName = value;
            }
        }

        public delegate void StudentHandler(Student student, string str);
        public event StudentHandler studentDidTheTask;

        public string DoTask()
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var randomString = new string(System.Linq.Enumerable.Repeat(chars, STRINGLENGTH).Select(s => s[random.Next(s.Length)]).ToArray());

            studentDidTheTask?.Invoke(this, randomString);
            return randomString.ToString();
        }
    }
}
