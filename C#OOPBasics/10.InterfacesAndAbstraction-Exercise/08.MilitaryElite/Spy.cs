using System;

public class Spy:Soldier
{
    public int CodeNumber { get; set; }

    public Spy(int id, string firstName, string lastName, int codeNumber)
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}{Environment.NewLine}" +
               $"Code Number: {this.CodeNumber}";
    }
}