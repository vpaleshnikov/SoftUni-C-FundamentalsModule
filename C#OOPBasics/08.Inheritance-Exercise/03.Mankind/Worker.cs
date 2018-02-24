using System;

public class Worker : Human
{
    private decimal weekSalary;

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    private decimal workHoursPerDay;

    public decimal WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal GetHourlySalary()
    {
        return (this.WeekSalary / 5) / this.WorkHoursPerDay;
    }

    public override string ToString()
    {
        return $"First Name: {base.FirstName}{Environment.NewLine}" +
               $"Last Name: {base.LastName}{Environment.NewLine}" +
               $"Week Salary: {this.WeekSalary:F2}{Environment.NewLine}" +
               $"Hours per day: {this.WorkHoursPerDay:F2}{Environment.NewLine}" +
               $"Salary per hour: {this.GetHourlySalary():F2}{Environment.NewLine}";
    }
}