﻿public class Citizen:IIdentifiable,IBirthable
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public string Id { get; private set; }
    public string Birthdate { get; private set; }

    public Citizen(string name, int age, string id, string birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthDate;
    }
}