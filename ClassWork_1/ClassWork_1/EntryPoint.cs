using System;
using System.Collections.Generic;

namespace ClassWork_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            List<Student> students = new List<Student>();
          

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student("FirstName" + i.ToString(), "LastName" + i.ToString()));
                teacher.StudentFinishedTheWork(students[i]);
            }

            foreach (Student student in students)

            {
                student.DoTask();                               
            }
            
        }
    }
}
