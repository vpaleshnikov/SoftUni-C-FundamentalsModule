using System;

public class StartUp
{
    public static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            var input = Console.ReadLine().Split();

            if (input.Length == 3)
            {
                var name = input[0] + " " + input[1];
                var address = input[2];
                var tuple = new Tuple<string>(name, address);
                Console.WriteLine(tuple);
            }
            if (input.Length == 2)
            {
                Console.WriteLine(new Tuple<string>(input[0], input[1]));
            }
        }
    }
}