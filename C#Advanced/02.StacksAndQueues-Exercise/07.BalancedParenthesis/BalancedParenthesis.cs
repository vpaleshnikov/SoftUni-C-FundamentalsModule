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
            var charStack = new Stack<char>();
            var isBalanced = true;
            
            foreach (var ch in input)
            {
                if (ch == '{' || ch == '(' || ch == '[')
                {
                    charStack.Push(ch);
                }
                if (ch == '}')
                {
                    if (!charStack.Any())
                    {
                        isBalanced = false;
                    }
                    else if (charStack.Pop() != '{')
                    {
                        isBalanced = false;
                    }
                }
                if (ch == ')')
                {
                    if (!charStack.Any())
                    {
                        isBalanced = false;
                    }
                    else if (charStack.Pop() != '(')
                    {
                        isBalanced = false;
                    }
                }

                if (ch == ']')
                {
                    if (!charStack.Any())
                    {
                        isBalanced = false;
                    }
                    else if (charStack.Pop() != '[')
                    {
                        isBalanced = false;
                    }
                }
            }
            if (isBalanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}