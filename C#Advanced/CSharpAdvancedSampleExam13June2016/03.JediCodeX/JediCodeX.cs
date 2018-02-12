using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.JediCodeX
{
    class JediCodeX
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                text.Append(input);
            }

            var namePattern = Console.ReadLine();
            var msgPattern = Console.ReadLine();

            var msgsIndexes = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            Regex nameRegex = new Regex(Regex.Escape(namePattern) + @"([a-zA-Z]{" + namePattern.Length + @"})(?![a-zA-Z])");
            Regex msgRegex = new Regex(Regex.Escape(msgPattern) + @"([a-zA-Z0-9]{" + msgPattern.Length + @"})(?![a-zA-Z0-9])");
            
            var jedis = new List<string>();
            var msgs = new List<string>();

            var jediMatches = nameRegex.Matches(text.ToString());
            var msgMatches = msgRegex.Matches(text.ToString());

            foreach (Match jediMatch in jediMatches)
            {
                jedis.Add(jediMatch.Groups[1].Value);
            }

            foreach (Match msgMatch in msgMatches)
            {
                msgs.Add(msgMatch.Groups[1].Value);
            }

            int currentJediIndex = 0;

            var output = new List<string>();

            for (int i = 0; i < msgsIndexes.Length; i++)
            {
                if (msgsIndexes[i] - 1 < msgs.Count)
                {
                    output.Add($"{jedis[currentJediIndex]} - {msgs[msgsIndexes[i] - 1]}");
                    currentJediIndex++;
                }

                if (currentJediIndex >= jedis.Count)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, output));
        }
    }
}