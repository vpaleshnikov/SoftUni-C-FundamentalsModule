public class SpecialisedSoldier:Private
{
    public string Corp { get; set; }

    public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corp) 
        : base(id, firstName, lastName, salary)
    {
        this.Corp = corp;
    }
}