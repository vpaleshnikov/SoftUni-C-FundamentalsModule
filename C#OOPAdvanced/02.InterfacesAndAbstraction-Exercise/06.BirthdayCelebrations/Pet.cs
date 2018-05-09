public class Pet : IBirthdate
{
    public Pet(string birthdate)
    {
        this.BirthDate = birthdate;
    }

    public string BirthDate { get; }
}
