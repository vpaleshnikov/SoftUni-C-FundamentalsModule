using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public bool IsEmpty()
    {
        if (this.data.Count == 0)
        {
            return true;
        }

        return false;
    }

    public void Push(string elementToPush)
    {
        data.Add(elementToPush);
    }

    public string Pop()
    {
        var lastElement = string.Empty;
        if (!IsEmpty())
        {
            int lastIndex = data.Count - 1;
            lastElement = data[lastIndex];
            data.Remove(data[lastIndex]);
        }

        return lastElement;
    }

    public string Peek()
    {
        var lastElement = string.Empty;
        if (!IsEmpty())
        {
            lastElement = data[data.Count - 1];
        }

        return lastElement;
    }
}