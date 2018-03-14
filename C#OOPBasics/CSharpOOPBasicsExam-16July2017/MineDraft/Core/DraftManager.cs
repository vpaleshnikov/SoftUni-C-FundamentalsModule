using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

public class DraftManager
{
    public DraftManager()
    {
        this.Harversters = new Dictionary<string, Harvester>();
        this.Providers = new Dictionary<string, Provider>();
        this.StoredEnergy = 0;
        this.OreSum = 0;
        this.ModeType = "Full";
    }

    public double StoredEnergy { get; set; }

    public double OreSum { get; set; }

    public string ModeType { get; set; }

    public Dictionary<string, Harvester> Harversters { get; set; }

    public Dictionary<string, Provider> Providers { get; set; }

    public string RegisterHarvester(List<string> arguments)
    {
        var result = string.Empty;
        try
        {
            var type = arguments[0];
            var id = arguments[1];

            if (!this.Harversters.ContainsKey(id))
            {
                if (type == "Hammer")
                {
                    this.Harversters.Add(id, new HammerHarvester(double.Parse(arguments[2]), double.Parse(arguments[3])));
                }
                else
                {
                    this.Harversters.Add(id, new SonicHarvester(double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4])));
                }
            }

            result = $"Successfully registered {type} Harvester - {id}";
        }
        catch (ArgumentException ae)
        {
            result = ae.Message;
        }
        return result;
    }

    public string RegisterProvider(List<string> arguments)
    {
        var result = string.Empty;
        try
        {

            var type = arguments[0];
            var id = arguments[1];

            if (!this.Providers.ContainsKey(id))
            {
                if (type == "Solar")
                {
                    this.Providers.Add(id, new SolarProvider(double.Parse(arguments[2])));
                }
                else
                {
                    this.Providers.Add(id, new PressureProvider(double.Parse(arguments[2])));
                }
            }

            result = $"Successfully registered {type} Provider - {id}";
        }

        catch (ArgumentException ae)
        {
            result = ae.Message;
        }
        return result;
    }

    public string Day()
    {
        var energyProvided = this.Providers.Select(p => p.Value.EnergyOutput).Sum();
        this.StoredEnergy += energyProvided;
        var energyRequired = this.Harversters.Select(h => h.Value.EnergyRequirement).Sum();
        var summedOreOutput = 0.00;
        var totalWorkDone = this.Harversters.Select(h => h.Value.OreOutput).Sum();


        if (this.ModeType == "Full")
        {
            if (this.StoredEnergy >= energyRequired)
            {
                this.StoredEnergy -= energyRequired;
                summedOreOutput = totalWorkDone;
            }
        }
        else if (this.ModeType == "Half")
        {
            energyRequired *= 0.6;

            if (this.StoredEnergy >= energyRequired)
            {
                this.StoredEnergy -= energyRequired;
                summedOreOutput = totalWorkDone * 0.5;
            }
        }

        this.OreSum += summedOreOutput;

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {energyProvided}");
        sb.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        var inputType = arguments[0];

        this.ModeType = inputType;

        return $"Successfully changed working mode to {inputType} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        var sb = new StringBuilder();

        if (this.Harversters.ContainsKey(id) || this.Providers.ContainsKey(id))
        {
            if (this.Harversters.Any(h => h.Key == id))
            {
                foreach (var harverster in this.Harversters)
                {
                    if (harverster.Key == id)
                    {
                        if (harverster.Value.GetType().FullName == "HammerHarvester")
                        {
                            sb.AppendLine($"Hammer Harvester - {id}");
                            sb.AppendLine($"Ore Output: {harverster.Value.OreOutput}");
                            sb.AppendLine($"Energy Requirement: {harverster.Value.EnergyRequirement}");
                        }
                        else if (harverster.Value.GetType().FullName == "SonicHarvester")
                        {
                            sb.AppendLine($"Sonic Harvester - {id}");
                            sb.AppendLine($"Ore Output: {harverster.Value.OreOutput}");
                            sb.AppendLine($"Energy Requirement: {harverster.Value.EnergyRequirement}");
                        }
                    }
                }
            }
            else if (this.Providers.Any(p => p.Key == id))
            {
                foreach (var provider in this.Providers)
                {
                    if (provider.Key == id)
                    {
                        if (provider.Value.GetType().Name == "SolarProvider")
                        {
                            sb.AppendLine($"Solar Provider - {id}");
                            sb.AppendLine($"Energy Output: {provider.Value.EnergyOutput}");
                        }
                        else if (provider.Value.GetType().Name == "PressureProvider")
                        {
                            sb.AppendLine($"Pressure Provider - {id}");
                            sb.AppendLine($"Energy Output: {provider.Value.EnergyOutput}");
                        }
                    }
                }
            }
        }
        else
        {
            sb.AppendLine($"No element found with id - {id}");
        }

        return sb.ToString().Trim();
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.StoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.OreSum}");

        return sb.ToString().Trim();
    }
}