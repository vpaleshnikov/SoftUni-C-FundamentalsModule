public class HammerHarvester : Harvester
{
    public HammerHarvester(double oreOutput, double energyRequirement)
        : base(oreOutput, energyRequirement)
    {
        this.OreOutput = oreOutput * 3;
        this.EnergyRequirement = energyRequirement * 2;
    }
}