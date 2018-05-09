using System.Collections.Generic;

public class ListyIterator<T>
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
        if (this.currentInternalIndex < this.collection.Count - 1)
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

    public bool HasNext()
    {
        return this.currentInternalIndex < this.collection.Count - 1;
    }
}