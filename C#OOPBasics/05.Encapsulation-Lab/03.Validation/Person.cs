using System;

public class Person
{
    private const int minLenght = 3;
    private const decimal minSalary = 460;

    private string firstName;

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (value?.Length < minLenght)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this.firstName = value;
        }
    }

    private string lastName;

    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value?.Length < minLenght)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this.lastName = value;
        }
    }

    private int age;

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }

    private decimal salary;

    public decimal Salary
    {
        get { return this.salary; }
        private set
        {
            if (value < minSalary)
            {
                throw new ArgumentException($"Salary cannot be less than {minSalary} leva!");
            }
            this.salary = value;
        }
    }


    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public Person(string firstName, string lastName, int age, decimal salary) 
        : this(firstName, lastName, age)
    {
        this.Salary = salary;
    }

    public void IncreaseSalary(decimal persentage)
    {
        if (this.age > 30)
        {
            salary += salary * (persentage / 100);
        }
        else
        {
            salary += salary * (persentage / 200);
        }
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary:F2} leva.";
    }
}