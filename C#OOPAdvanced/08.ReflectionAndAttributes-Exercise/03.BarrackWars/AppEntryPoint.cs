using System;

public class AppEntryPoint
{
    static void Main(string[] args)
    {
        ICommandInterpreter commandInterpreter = new CommandInterpreter();
        IRepository repository = new UnitRepository();
        IUnitFactory unitFactory = new UnitFactory();

        IRunnable engine = new Engine(commandInterpreter);
        engine.Run();
    }
}