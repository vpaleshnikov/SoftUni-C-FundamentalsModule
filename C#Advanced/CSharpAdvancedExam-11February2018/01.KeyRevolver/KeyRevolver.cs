using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            var priceOfBullets = int.Parse(Console.ReadLine());
            var sizeOfGunBarrel = int.Parse(Console.ReadLine());
            var bulletsInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var locksInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var valueOfIntelligence = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>();
            var locks = new Queue<int>();

            for (int i = 0; i < bulletsInput.Length; i++)
            {
                bullets.Push(bulletsInput[i]);
            }

            for (int i = 0; i < locksInput.Length; i++)
            {
                locks.Enqueue(locksInput[i]);
            }

            var counter = 0;
            var bulletsCounter = bullets.Count;
            var shootedBullets = 0;

            while (locks.Count >= 0 && bullets.Count >= 0)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                    bulletsCounter--;
                    shootedBullets++;
                }

                else if (bullets.Peek() > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    bulletsCounter--;
                    shootedBullets++;
                }

                counter++;
                if (counter % sizeOfGunBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }

                if (bullets.Count <= 0 || locks.Count <= 0)
                {
                    break;
                }
            }

            var bulletsCost = shootedBullets * priceOfBullets;
            var earned = valueOfIntelligence - bulletsCost;

            if (bullets.Count >= 0 && locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earned}");
            }
            else if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
