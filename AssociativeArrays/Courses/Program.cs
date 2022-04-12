using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courseMap = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string course = input.Split(" : ")[0];
                string student = input.Split(" : ")[1];

                if (!courseMap.ContainsKey(course))
                {
                    courseMap.Add(course, new List<string>());
                }
                courseMap[course].Add(student);

                input = Console.ReadLine();

            }

            foreach (var course in courseMap.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var name in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
