using System;

public class StartUp
{
    public static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            var input = Console.ReadLine().Split();

            if (int.TryParse(input[1], out var number))
            {
                var drunkOrNot = input[2] == "drunk" ? "True" : "False";
                Console.WriteLine(new Tuple<string>(input[0], input[1], drunkOrNot));
            }
            else if (double.TryParse(input[1], out var dNumber))
            {
                var output = $"{dNumber:f1}";
                Console.WriteLine(new Tuple<string>(input[0], output, input[2]));
            }
            else
            {
                var first = input[0] + " " + input[1];
                Console.WriteLine(new Tuple<string>(first, input[2], input[3]));
            }
        }
    }
}