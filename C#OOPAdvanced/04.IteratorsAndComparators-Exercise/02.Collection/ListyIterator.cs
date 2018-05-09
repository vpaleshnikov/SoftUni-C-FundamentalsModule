using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> 
    : IEnumerable<T>
{
    private List<T> collection;
    private int currentInternalIndex;
    
    public ListyIterator()
    {
        this.collection = new List<T>();
        this.currentInternalIndex = 0;
    }

    public void Create(params T[] collection)
    {
        this.collection.AddRange(collection);
    }

    public bool Move()
    {
        if (this.currentInternalIndex + 1 < this.collection.Count)
        {
            this.currentInternalIndex++;
            return true;
        }

        return false;
    }

    public void Print()
    {
        if (this.collection == null || this.collection.Count == 0)
        {
            System.Console.WriteLine("Invalid Operation!");
        }
        else
        {
            System.Console.WriteLine(this.collection[this.currentInternalIndex]);
        }
    }

    public string PrintAll()
    {
        var result = "";

        foreach (var item in this.collection)
        {
            result += item + " ";
        }

        return result.Trim();
    }

    public bool HasNext()
    {
        return this.currentInternalIndex < this.collection.Count - 1;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.collection.Count; i++)
        {
            yield return this.collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}