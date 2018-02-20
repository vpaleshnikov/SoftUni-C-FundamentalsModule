using System;

public class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        this.Name = name;
        this.Age = age;
        this.Grade = grade;
    }

    public override string ToString()
    {
        var gradeComment = GetGradeComment();

        return $"{Name} is {Age} years old. {gradeComment}";
    }

    private string GetGradeComment()
    {
        if (Grade >= 5.00)
        {
            return "Excellent student.";
        }
        else if (Grade < 5.00 && Grade >= 3.50)
        {
            return "Average student.";
        }
        else
        {
            return "Very nice person.";
        }
    }
}