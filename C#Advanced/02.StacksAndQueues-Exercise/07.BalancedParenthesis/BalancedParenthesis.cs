using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            char[] opening = new char[] { '(', '{', '[' };
            char[] closing = new char[] { ')', ']', '[' };

            var stack = new Stack<char>();

            foreach (var element in input)
            {
                if (opening.Contains(element))
                {
                    stack.Push(element);
                }
                else if (closing.Contains(element))
                {
                    var lastElement = stack.Pop();

                    int openingIndex = Array.IndexOf(opening, lastElement);
                    int closingIndex = Array.IndexOf(closing, element);

                    if (openingIndex != closingIndex)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }

            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

           //var charStack = new Stack<char>();
           //var isBalanced = true;
           //
           //foreach (var ch in input)
           //{
           //    if (ch == '{' || ch == '(' || ch == '[')
           //    {
           //        charStack.Push(ch);
           //    }
           //    if (ch == '}')
           //    {
           //        if (!charStack.Any())
           //        {
           //            isBalanced = false;
           //        }
           //        else if (charStack.Pop() != '{')
           //        {
           //            isBalanced = false;
           //        }
           //    }
           //    if (ch == ')')
           //    {
           //        if (!charStack.Any())
           //        {
           //            isBalanced = false;
           //        }
           //        else if (charStack.Pop() != '(')
           //        {
           //            isBalanced = false;
           //        }
           //    }
           //
           //    if (ch == ']')
           //    {
           //        if (!charStack.Any())
           //        {
           //            isBalanced = false;
           //        }
           //        else if (charStack.Pop() != '[')
           //        {
           //            isBalanced = false;
           //        }
           //    }
           //}
           //if (isBalanced == true)
           //{
           //    Console.WriteLine("YES");
           //}
           //else
           //{
           //    Console.WriteLine("NO");
           //}
        }  
    }
}