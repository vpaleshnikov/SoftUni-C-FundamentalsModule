﻿using System;

public class Child:Person
{
    private string name;

    public override string Name
    {
        get { return base.Name; }
        set { base.Name = value; }
    }

    private int age;

    public override int Age
    {
        get { return base.Age; }
        set
        {
            if (value >= 15)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
            base.Age = value;
        }
    }


    public Child(string name, int age) : base(name, age)
    {
        this.Name = name;
        this.Age = age;
    }
}