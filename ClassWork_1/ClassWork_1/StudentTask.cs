using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_1
{
    public class StudentTask
    {
        string _answer;

        public StudentTask(string answer)
        {
            Answer = answer;
        }

        public string Answer
        {
            get => _answer;
            private set
            {
                _answer = value;
            }
        }
    }
}
