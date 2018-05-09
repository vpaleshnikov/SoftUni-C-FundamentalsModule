using System;

public class UnitFactory : IUnitFactory
{
    public IUnit CreateUnit(string unitType)
    {
        var uType = Type.GetType(unitType);
        var unitInstance = (IUnit)Activator.CreateInstance(uType);
        return unitInstance;
    }
}