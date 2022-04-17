using System;
using System.Collections.Generic;
using System.Linq;
namespace OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> personList = new List<Person>();
            while (input != "End")
            {
                string name = input.Split()[0];
                string id = input.Split()[1];
                int age = int.Parse(input.Split()[2]);

                Person person = new Person(name, id, age);
                if (personList.Any(x=>x.ID == id))
                {
                    personList.Where(x => x.ID == id).First().Age = age;
                    personList.Where(x => x.ID == id).First().Name = name;
                }
                else
                {
                    personList.Add(person);                
                }

                input = Console.ReadLine();
            }

            foreach (var people in personList.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{people.Name} with ID: {people.ID} is {people.Age} years old.");
            }
        }
    }
}
