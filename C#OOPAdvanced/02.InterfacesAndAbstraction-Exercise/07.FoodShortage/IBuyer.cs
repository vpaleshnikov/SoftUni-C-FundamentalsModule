public interface IBuyer
{
    string Name { get; }

    int Food { get; set; }

    int BuyFood();
}
