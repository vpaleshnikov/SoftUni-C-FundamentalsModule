public class Repair
{
    public string PartName { get; set; }

    public int HoursWorked { get; set; }

    public Repair(string partName, int hours)
    {
        this.PartName = partName;
        this.HoursWorked = hours;
    }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}