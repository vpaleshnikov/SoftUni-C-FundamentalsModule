public class PriceCalculator
{
    public decimal PricePerDay { get; set; }

    public int NumberOfDays { get; set; }

    public string Season { get; set; }

    private string discountType;

    public string DiscountType
    {
        get { return this.discountType; }
        set { this.discountType = value; }
    }



    public PriceCalculator(decimal pricePerDay, int numberOfDays, string season)
    {
        this.PricePerDay = pricePerDay;
        this.NumberOfDays = numberOfDays;
        this.Season = season;
        this.DiscountType = "";
    }

    public decimal Calculator(PriceCalculator calculator)
    {
        decimal discountedPrice = 0m;


        decimal totalPrice = 0m;

        if (this.Season == "Autumn")
        {
            totalPrice = this.PricePerDay * this.NumberOfDays;
        }
        else if (this.Season == "Spring")
        {
            totalPrice = (this.PricePerDay * 2) * this.NumberOfDays;
        }
        else if (this.Season == "Winter")
        {
            totalPrice = (this.PricePerDay * 3) * this.NumberOfDays;
        }
        else if (this.Season == "Summer")
        {
            totalPrice = (this.PricePerDay * 4) * this.NumberOfDays;
        }

        if (this.DiscountType != "")
        {
            if (this.DiscountType == "VIP")
            {
                discountedPrice = totalPrice - (totalPrice * 0.2m);
            }
            else if (this.DiscountType == "SecondVisit")
            {
                discountedPrice = totalPrice - (totalPrice * 0.1m);
            }
        }

        if (discountedPrice > 0)
        {
            return discountedPrice;
        }
        else
        {
            return totalPrice;
        }
    }
}