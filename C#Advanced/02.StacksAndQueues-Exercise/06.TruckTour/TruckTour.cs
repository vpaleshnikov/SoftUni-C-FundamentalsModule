using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            }

            for (int i = 0; i < n; i++)
            {
                if (Solution(pumps, n))
                {
                    Console.WriteLine(i);
                    break;
                }
                int[] startPump = pumps.Dequeue();
                pumps.Enqueue(startPump);
            }
        }

        static bool Solution(Queue<int[]> pumps, int n)
        {
            int tankFuel = 0;
            bool isEnough = true;

            for (int i = 0; i < n; i++)
            {
                int[] currentPump = pumps.Dequeue();
                tankFuel += currentPump[0] - currentPump[1];
                if (tankFuel < 0)
                {
                    isEnough = false;
                }
                pumps.Enqueue(currentPump);
            }

            if (isEnough)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
