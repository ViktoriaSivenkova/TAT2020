using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassWork_1
{
    public class Teacher
    {
        const int MaxStudentsNumber = 10;
        private List<string> TaskResults;
        delegate void EventHandler(Student student, string taskString);

        public Teacher()
        {
            TaskResults = new List<string>();
        }

        public void TaskCompleted(Student sender, string task)
        {
            Student student = (Student)sender;
            if (IsStudentInGroup(student) == false)
            {
                TaskResults.Add(student.FirstName + " " + student.LastName + " " + task);
                if (TaskResults.Count == MaxStudentsNumber)
                {
                    PrintAllResults(TaskResults);
                }
            }
        }

        private bool IsStudentInGroup(Student student)
        {
            return TaskResults.All(t => t.Contains(student.FirstName) && t.Contains(student.LastName));
        }

        public void PrintAllResults(List<string> taskResults)
        {
            foreach (var studentTask in TaskResults)
            {
                Console.WriteLine(studentTask);
            }
        }

        public void StudentFinishedTheWork(Student student)
        {
            student.studentDidTheTask += TaskCompleted;
        }
    }
}
