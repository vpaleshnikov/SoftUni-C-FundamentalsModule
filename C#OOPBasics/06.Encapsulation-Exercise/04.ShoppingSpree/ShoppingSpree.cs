using System;
using System.Collections.Generic;

public class ShoppingSpree
{
    public static void Main()
    {
        try
        {
            var peopleInput = Console.ReadLine()
                .Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            var people = new List<Person>();
            AddPeople(people, peopleInput);

            var productsInput = Console.ReadLine()
                .Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries);
            var products = new List<Product>();
            AddProducts(productsInput, products);

            string shopping;
            while ((shopping = Console.ReadLine()) != "END")
            {
                var purchases = shopping.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                Shopping(people, products, purchases);
            }

            PrintResult(people);
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
            Environment.Exit(0);
        }
    }

    private static void Shopping(List<Person> people, List<Product> products, string[] purchases)
    {
        var costumerName = purchases[0];
        var productName = purchases[1];

        foreach (var person in people)
        {
            foreach (var product in products)
            {
                if (person.Name == costumerName && product.Name == productName)
                {
                    if (person.Money >= product.Cost)
                    {
                        person.Money -= product.Cost;
                        Console.WriteLine($"{costumerName} bought {productName}");
                        person.ShoppingBag.Add(productName);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{costumerName} can't afford {productName}");
                        break;
                    }
                }
            }
        }
    }

    private static void PrintResult(List<Person> people)
    {
        foreach (var person in people)
        {
            if (person.ShoppingBag.Count == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.Write($"{person.Name} - ");
                Console.WriteLine(string.Join(", ", person.ShoppingBag));
            }
        }
    }

    private static void AddPeople(List<Person> people, string[] peopleInput)
    {
        for (int i = 0; i < peopleInput.Length; i++)
        {
            var splitInput = peopleInput[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
            var name = splitInput[0];
            var money = decimal.Parse(splitInput[1]);

            var person = new Person(name, money);
            people.Add(person);
        }
    }

    private static void AddProducts(string[] productsInput, List<Product> products)
    {
        for (int i = 0; i < productsInput.Length; i++)
        {
            var splitInput = productsInput[i]
                .Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
            var name = splitInput[0];
            var cost = decimal.Parse(splitInput[1]);

            var product = new Product(name, cost);

            products.Add(product);
        }
    }
}