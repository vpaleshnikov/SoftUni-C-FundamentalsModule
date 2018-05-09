using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(BindingFlags.Instance
            | BindingFlags.Public
            | BindingFlags.Static);

        foreach (var methodInfo in methods)
        {
            if (methodInfo.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
            {
                var attributes = methodInfo.GetCustomAttributes(false);
                foreach (SoftUniAttribute attribute in attributes)
                {
                    System.Console.WriteLine($"{methodInfo.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}