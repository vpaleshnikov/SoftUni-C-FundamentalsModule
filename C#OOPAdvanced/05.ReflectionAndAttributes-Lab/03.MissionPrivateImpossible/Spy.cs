using System;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string investigatedClass)
    {
        var classType = Type.GetType(investigatedClass);
        var classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {investigatedClass}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }
}