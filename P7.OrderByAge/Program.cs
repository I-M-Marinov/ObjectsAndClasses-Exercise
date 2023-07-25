using System;
using System.Collections.Generic;
using System.Linq;

namespace P7.OrderByAge
{
    public class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            List<People> people = new List<People>();

            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);
                People person = new People(name, id, age);
                people.Add(person);

                input = Console.ReadLine().Split(" ").ToList();
            }
            foreach (People person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
