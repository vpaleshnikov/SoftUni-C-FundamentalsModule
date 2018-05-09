public class Tuple<T>
{
    private T item1;
    private T item2;
    private T item3;

    public Tuple(T item1, T item2, T item3)
    {
        this.item1 = item1;
        this.item2 = item2;
        this.item3 = item3;
    }

    public override string ToString()
    {
        return $"{this.item1} -> {this.item2} -> {this.item3}";
    }
}