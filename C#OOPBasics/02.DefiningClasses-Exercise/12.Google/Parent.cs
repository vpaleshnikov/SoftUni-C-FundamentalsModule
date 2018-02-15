using System;

public class Parent
{
    public string Name { get; set; }

    public DateTime Birthday { get; set; }

    public Parent(string name, DateTime birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }
}