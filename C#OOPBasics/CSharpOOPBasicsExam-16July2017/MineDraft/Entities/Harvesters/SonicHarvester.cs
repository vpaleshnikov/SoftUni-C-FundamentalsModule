public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequierment, int sonicFactor)
        : base(id, oreOutput, energyRequierment)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }

    public int SonicFactor
    {
        get { return sonicFactor; }
        private set { sonicFactor = value; }
    }

    public override string ToString()
    {
        return $"Sonic {base.ToString().Trim()}";
    }
}