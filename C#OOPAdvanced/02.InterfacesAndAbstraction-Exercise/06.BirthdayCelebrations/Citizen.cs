public class Citizen : IBirthdate
{
    public Citizen(string birthdate)
    {
        this.BirthDate = birthdate;
    }

    public string BirthDate { get; }
}
