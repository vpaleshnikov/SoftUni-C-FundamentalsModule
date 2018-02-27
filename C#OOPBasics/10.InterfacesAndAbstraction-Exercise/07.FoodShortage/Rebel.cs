public class Rebel : IBuyer
{
    public string Name { get; }

    public Rebel(string name)
    {
        this.Name = name;
    }
}