public class Cat
{
    private string breed;

    public string Breed { get; set; }

    private string name;

    public string Name { get; set; }

    public Siamese Siamese { get; set; }

    public Cymric Cymric { get; set; }

    public StreetExtraordinaire StreetExtraordinaire { get; set; }

    public Cat()
    {
        this.Breed = breed;
        this.Name = name;
    }
}