using System.Text;

public class ShowCar : Car
{
    public ShowCar(int id, string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability) 
        : base(id, brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public int Stars { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        if (this.Stars > 0)
        {
            sb.AppendLine($"{this.Stars} *");
        }

        return sb.ToString().Trim();
    }
}