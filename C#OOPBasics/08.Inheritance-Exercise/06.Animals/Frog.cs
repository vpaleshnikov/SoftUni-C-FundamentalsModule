﻿public class Frog : Animal
{

    public override string ProduceSound()
    {
        return "Ribbit";
    }

    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
    }
}