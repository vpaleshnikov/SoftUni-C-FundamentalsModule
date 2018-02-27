﻿using System;

public class Tesla : IElectricCar
{
    public string Model { get; }
    public string Color { get; }
    public int Battery { get; }

    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = batteries;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.Color} Tesla {this.Model}{Environment.NewLine}{this.Start()}{Environment.NewLine}{this.Stop()}";
    }
}