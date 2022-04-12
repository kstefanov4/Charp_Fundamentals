using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentMap = new Dictionary<string, double>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentMap.ContainsKey(name))
                {
                    studentMap.Add(name, grade);
                }
                else
                {
                    double currentGrade = studentMap[name];
                    studentMap[name] = (currentGrade + grade) / 2; 
                }
            }

            studentMap = studentMap.Where(x => x.Value >= 4.50).ToDictionary(x => x.Key, v => v.Value);
            foreach (var student in studentMap)
            {
                Console.WriteLine($"{student.Key} -> {student.Value}");
            }
        }
    }
}
