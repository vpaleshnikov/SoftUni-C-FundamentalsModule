using System;
using System.Linq;
using System.Reflection;

public class HarvestingFieldsTest
{
    public static void Main()
    {
        var harvestingFieldsType = typeof(HarvestingFields);
        var harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        string command;

        while ((command = Console.ReadLine()) != "HARVEST")
        {
            FieldInfo[] currentFields;

            switch (command)
            {
                case "private":
                    currentFields = harvestingFields.Where(f => f.IsPrivate).ToArray();
                    break;
                case "protected":
                    currentFields = harvestingFields.Where(f => f.IsFamily).ToArray();
                    break;
                case "public":
                    currentFields = harvestingFields.Where(f => f.IsPublic).ToArray();
                    break;
                case "all":
                    currentFields = harvestingFields;
                    break;
                default:
                    currentFields = null;
                    break;
            }

            var result = currentFields.Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}").ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
        }
    }
}