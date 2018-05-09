public class StartUp
{
    public static void Main()
    {
        var scale = new Scale<int>(8, 5);

        Console.WriteLine(scale.GetHavier());
    }
}