using System;

public class Child
{
    public string Name { get; set; }

    public DateTime Birthday { get; set; }

    public Child(string name, DateTime birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }
}