using System;

public class SonicHarvester : Harvester
{
    public SonicHarvester(double oreOutput, double energyRequirement, int sonicFactor)
        : base(oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement = energyRequirement / sonicFactor;
    }

    private int sonicFactor;

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        protected set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Harvester is not registered, because of it's SonicFactor");
            }
            this.sonicFactor = value;
        }
    }
}