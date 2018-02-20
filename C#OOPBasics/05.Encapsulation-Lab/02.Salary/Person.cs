public class Person
{
    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public Person(string firstName, string lastName, int age, decimal salary) 
        : this(firstName, lastName, age)
    {
        this.salary = salary;
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