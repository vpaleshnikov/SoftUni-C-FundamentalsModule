using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CustomStack<T>
    : IEnumerable<T>
{
    private T[] customStack;
    private int currentCount = 0;

    public CustomStack()
    {
        this.customStack = new T[this.currentCount];
    }

    public void Push(T[] outputCollection)
    {
        var start = this.customStack.Length;
        var end = this.customStack.Length + outputCollection.Length;

        var newCollection = new T[end];

        if (this.customStack.Length == 0)
        {
            for (int i = 0; i < end; i++)
            {
                newCollection[i] = outputCollection[i];
            }
        }
        else
        {
            for (int i = 0; i < start; i++)
            {
                newCollection[i] = this.customStack[i];
            }

            for (int j = 0; j < outputCollection.Length; j++)
            {
                newCollection[start] = outputCollection[j];

                start++;
            }
        }
        this.customStack = newCollection;
    }

    public void Pop()
    {
        if (this.customStack.Length == 0)
        {
            Console.WriteLine("No elements");   
            return;
        }
        var newCollection = new T[this.customStack.Length - 1];

        for (int i = 0; i < this.customStack.Length - 1; i++)
        {
            newCollection[i] = this.customStack[i];
        }

        T element = this.customStack[this.customStack.Length - 1];

        this.customStack = newCollection;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.customStack.Length; i++)
        {
            yield return this.customStack[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        if (this.customStack.Length > 0)
        {
            for (int i = this.customStack.Length - 1; i >= 0; i--)
            {
                sb.AppendLine(this.customStack[i].ToString());
            }
            for (int i = this.customStack.Length - 1; i >= 0; i--)
            {
                sb.AppendLine(this.customStack[i].ToString());
            }
        }

        return sb.ToString().Trim();
    }
}