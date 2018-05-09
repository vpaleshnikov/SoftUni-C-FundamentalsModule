public class Smartphone : IPhone, IBrowser
{
    private string number;
    private string url;

    public Smartphone()
    {
        this.Number = number;
        this.Url = url;
    }

    public string Number
    {
        get
        {
            return this.number;
        }
        set
        {
            this.number = value;
        }
    }

    public string Url
    {
        get
        {
            return this.url;
        }
        set
        {
            this.url = value;
        }
    }

    public string Browse()
    {
        return $"Browsing: {this.Url}!";
    }

    public string Call()
    {
        return $"Calling... {this.Number}";
    }
}

