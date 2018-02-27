﻿using System;

public class Circle : IDrawable
{
    public int Radius { get; private set; }

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public void Draw()
    {
        double radiusIn = this.Radius - 0.4;
        double radiusOut = this.Radius + 0.4;

        for (double y = this.Radius; y >= -this.Radius; --y)
        {
            for (double x = -this.Radius; x < radiusOut; x += 0.5)
            {
                double value = x * x + y * y;

                if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}