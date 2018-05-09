using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var sortedPeopleByName = new SortedSet<Person>(new PersonNameComperator());
            var sortedPeopleByAge = new SortedSet<Person>(new PersonAgeComperator());

            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                sortedPeopleByName.Add(person);
                sortedPeopleByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedPeopleByName));
            Console.WriteLine(string.Join(Environment.NewLine, sortedPeopleByAge));
        }
    }
}
