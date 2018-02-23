using System;
using System.Collections.Generic;

public class RandomList:List<string>
{
    Random rnd = new Random();

    public string RandomString()
    {
        string result = string.Empty;
        if (this.Count > 0)
        {
            var randomIndex = rnd.Next(0, this.Count - 1);
            result = this[randomIndex];
            this.RemoveAt(randomIndex);
        }

        return result;
    }
}