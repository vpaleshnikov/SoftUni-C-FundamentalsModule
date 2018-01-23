using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fib = FibonacciNumber(n);
            fib = (FibonacciNumber(n - 1) + FibonacciNumber(n - 2) - 1);

            Console.WriteLine(fib);
        }

        static long FibonacciNumber(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
            }
            return secondNumber;
        }
    }
}
