using System;
using System.Linq;

public class Smartphone : ICallable, IBrowseable
{
    private string number;

    public string Number
    {
        get { return this.number; }
        set
        {
            if (value.Any(n => !char.IsDigit(n)))
            {
                throw new ArgumentException("Invalid number!");
            }
            this.number = value;
        }
    }

    private string website;

    public string Website
    {
        get { return this.website; }
        set
        {
            if (value.Any(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            this.website = value;
        }
    }
    
    public string Call()
    {
        return $"Calling... {this.number}";
    }

    public string Browse()
    {
        return $"Browsing: {this.website}!";
    }
}