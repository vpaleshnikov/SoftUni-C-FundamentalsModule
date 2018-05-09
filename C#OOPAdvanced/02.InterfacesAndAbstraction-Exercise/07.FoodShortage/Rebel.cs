public class Rebel : IBuyer
{
    public Rebel(string name)
    {
        this.Name = name;
        this.Food = 0;
    }

    public string Name { get; }

    public int Food { get; set; }

    public int BuyFood()
    {
        return this.Food += 5;
    }
}
