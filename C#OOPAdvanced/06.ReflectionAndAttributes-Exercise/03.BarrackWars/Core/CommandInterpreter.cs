using System;
using System.Linq;
using System.Reflection;

public class CommandInterpreter
    : ICommandInterpreter
{
    private const string CommandSuffix = "command";

    private IRepository repository;
    private IUnitFactory unitFactory;

    public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
    {
        this.repository = repository;
        this.unitFactory = unitFactory;
    }


    public string InterpredCommand(string[] data, string commandName)
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        Type commandType = assembly.GetTypes()
            .FirstOrDefault(t => t.Name.ToLower() == commandName + CommandSuffix);

        if (commandType == null)
        {
            throw new ArgumentException("Invalid command!");
        }

        if (!typeof(IExecutable).IsAssignableFrom(commandType))
        {
            throw new ArgumentException($"{commandName} is not a command!");
        }

        MethodInfo method = typeof(IExecutable).GetMethods().First();
        var ctorArgs = new object[] { data, this.repository, this.unitFactory };
        var instance = Activator.CreateInstance(commandType, ctorArgs);

        return (string)method.Invoke(instance, null);
    }
}