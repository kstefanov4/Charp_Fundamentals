using System;
using System.Collections.Generic;
using System.Linq;

namespace T4._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondtName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{ FirstName} {SecondtName}: {Grade:F2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student();
                student.FirstName = firstName;
                student.SecondtName = secondName;
                student.Grade = grade;


                studentsList.Add(student);
            }

            studentsList = studentsList.OrderByDescending(student => student.Grade).ToList();

            foreach (var student in studentsList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
