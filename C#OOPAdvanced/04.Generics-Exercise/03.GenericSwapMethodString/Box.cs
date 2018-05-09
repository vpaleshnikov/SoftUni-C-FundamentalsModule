using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private T element;
    private IList<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public Box(T element)
    {
        this.element = element;
    }

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public void Swap(int first, int last)
    {
        var temp = data[first];
        data[first] = data[last];
        data[last] = temp;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (var item in data)
        {
            sb.AppendLine($"{item.GetType().FullName}: {item}");
        }

        return sb.ToString().Trim();
    }
}