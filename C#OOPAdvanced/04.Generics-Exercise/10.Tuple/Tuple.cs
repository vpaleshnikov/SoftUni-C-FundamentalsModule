public class Tuple<T>
{
    private T item1;
    private T item2;

    public Tuple(T item1, T item2)
    {
        this.item1 = item1;
        this.item2 = item2;
    }

    public override string ToString()
    {
        return $"{this.item1} -> {this.item2}";
    }
}