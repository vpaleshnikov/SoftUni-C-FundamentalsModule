public interface IBrowser
{
    string Url { get; set; }

    string Browse();
}