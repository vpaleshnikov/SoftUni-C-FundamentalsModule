public class BirthdateAble
{
    public string Name { get; set; }

    public string Day { get; set; }

    public string Month { get; set; }

    public string Year { get; set; }

    public BirthdateAble(string name, string day, string month, string year)
    {
        this.Name = name;
        this.Day = day;
        this.Month = month;
        this.Year = year;
    }
}