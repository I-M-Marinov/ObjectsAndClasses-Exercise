using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace P4.Students
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public Students (string firstname, string lastname, string grade)
        {
            FirstName = firstname;
            LastName = lastname;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfAllStudents = int.Parse(Console.ReadLine());
            List<Students> currentStudent = new List<Students>();

            for (int i = 0; i < numberOfAllStudents; i++)
            {
                List<string> students = Console.ReadLine().Split().ToList();
                Students student = new Students(students[0], students[1], students[2]);
                currentStudent.Add(student);

            }

            foreach (Students student in currentStudent.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
}

