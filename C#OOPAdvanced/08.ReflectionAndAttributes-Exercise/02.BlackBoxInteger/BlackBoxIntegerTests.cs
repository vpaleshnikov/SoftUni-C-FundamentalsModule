using System;
using System.Linq;
using System.Reflection;

public class BlackBoxIntegerTests
{
    public static void Main()
    {
        var blackBoxType = typeof(BlackBoxInt);
        var myBlackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split('_');
            var methodName = tokens[0];
            var value = int.Parse(tokens[1]);

            blackBoxType
                .GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                .Invoke(myBlackBox, new object[] { value });

            var innerValue = blackBoxType
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First()
                .GetValue(myBlackBox);

            Console.WriteLine(innerValue);
        }
    }
}