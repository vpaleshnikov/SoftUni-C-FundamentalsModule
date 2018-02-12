using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _03.CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var pattern = @"(^\d+)([a-zA-Z]+)([^a-zA-Z]*$)";

            string input;
            while ((input = Console.ReadLine()) != "Over!")
            {
                var msgLenght = int.Parse(Console.ReadLine());
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var msg = match.Groups[2].Value;
                    var ending = string.Empty;

                    if (match.Groups[3].Value != "")
                    {
                        ending = match.Groups[3].Value;
                    }

                    if (msg.Length != msgLenght)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(prefix + ending, @"\D*", string.Empty);

                    var sb = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        var ind = int.Parse(index.ToString());

                        if (ind >= 0 && ind < msgLenght)
                        {
                            sb.Append(msg[ind]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }
                    Console.WriteLine($"{msg} == {sb}");
                }
            }
        }
    }
}