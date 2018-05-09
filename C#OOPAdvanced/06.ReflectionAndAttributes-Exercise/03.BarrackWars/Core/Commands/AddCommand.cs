public class AddCommand : Command
{
    public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
        : base(data, repository, unitFactory)
    { }

    public override string Execute()
    {
        var unitType = Data[1];

        IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);

        this.Repository.AddUnit(unitToAdd);

        return unitType + " added";
    }
}