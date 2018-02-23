using System;

public class PizzaCalories
{
    public static void Main()
    {
        try
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();
                if (tokens[0].ToLower() == "dough")
                {
                    var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                    Console.WriteLine($"{dough.GetCalories():F2}");
                }
                else if (tokens[0].ToLower() == "topping")
                {
                    var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                    Console.WriteLine($"{topping.GetCalories():F2}");
                }
                else if (tokens[0].ToLower() == "pizza")
                {
                    MakePizza(tokens);
                    break;
                }
            }
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
        }
    }

    private static void MakePizza(string[] tokens)
    {
        var pizza = new Pizza(tokens[1]);

        var doughInfo = Console.ReadLine().Split();
        var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
        pizza.Dough = dough;

        string toppings;
        while ((toppings = Console.ReadLine()) != "END")
        {
            var toppingInfo = toppings.Split();
            var topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
            pizza.AddTopping(topping);
        }

        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
    }
}
