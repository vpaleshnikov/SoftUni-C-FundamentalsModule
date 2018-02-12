using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.JediMeditation
{
    class JediMeditation
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var mastersQueue = new Queue<string>();
            var knightsQueue = new Queue<string>();
            var padawansQueue = new Queue<string>();
            var specialCharacters = new Queue<string>();

            bool isYodaExist = false;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var jedi = input
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < jedi.Length; j++)
                {
                    var currentJedi = jedi[j][0];

                    switch (currentJedi)
                    {
                        case 'm':
                            mastersQueue.Enqueue(jedi[j] + " ");
                            break;
                        case 'k':
                            knightsQueue.Enqueue(jedi[j] + " ");
                            break;
                        case 'p':
                            padawansQueue.Enqueue(jedi[j] + " ");
                            break;
                        case 't':
                        case 's':
                            specialCharacters.Enqueue(jedi[j] + " ");
                            break;
                        case 'y':
                            isYodaExist = true;
                            break;
                    }
                }
            }

            if (isYodaExist)
            {
                var output = new StringBuilder();
                output.Append(string.Join("", mastersQueue));
                output.Append(string.Join("", knightsQueue));
                output.Append(string.Join("", specialCharacters));
                output.Append(string.Join("", padawansQueue));

                Console.WriteLine(output.ToString().Trim());
            }
            else
            {
                var output = new StringBuilder();
                output.Append(string.Join("", specialCharacters));
                output.Append(string.Join("", mastersQueue));
                output.Append(string.Join("", knightsQueue));
                output.Append(string.Join("", padawansQueue));

                Console.WriteLine(output.ToString().Trim());
            }
        }
    }
}
