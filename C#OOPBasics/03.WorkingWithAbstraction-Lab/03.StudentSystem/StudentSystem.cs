using System;
using System.Collections.Generic;

public class StudentSystem
{
    static void Main()
    {
        var students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "Exit")
        {
            var tokens = input
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens[0] == "Create")
            {
                students.Add(CreateNewStudent(tokens));
            }
            else if (tokens[0] == "Show")
            {
                ShowStudent(students, tokens);
            }
        }
    }

    public static void ShowStudent(List<Student> students, string[] tokens)
    {
        foreach (var student in students)
        {
            if (tokens[1] == student.Name)
            {
                if (student.Grade >= 5.00)
                {
                    Console.WriteLine($"{student.Name} is {student.Age} years old. Excellent student.");
                }
                else if (student.Grade < 5.00 && student.Grade >= 3.50)
                {
                    Console.WriteLine($"{student.Name} is {student.Age} years old. Average student.");
                }
                else
                {
                    Console.WriteLine($"{student.Name} is {student.Age} years old. Very nice person.");
                }
            }
        }
    }

    public static Student CreateNewStudent(string[] tokens)
    {
        var name = tokens[1];
        var age = int.Parse(tokens[2]);
        var grade = double.Parse(tokens[3]);

        return new Student(name, age, grade);
    }
}