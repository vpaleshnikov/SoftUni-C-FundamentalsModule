public class Private:Soldier
{
    public decimal Salary { get; set; }

    public Private(int id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
    }
}