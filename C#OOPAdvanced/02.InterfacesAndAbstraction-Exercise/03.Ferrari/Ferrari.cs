﻿public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        this.Driver = driver;
    }

    public string Model { get; }

    public string Driver { get; }

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }
}
