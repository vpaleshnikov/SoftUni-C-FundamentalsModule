public class Citizen:IBuyer
{
    public string Name { get; }

    public Citizen(string name)
    {
        this.Name = name;
    }
}