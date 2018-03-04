using System;
using System.Collections.Generic;

public class WildFarm
{
    public static void Main()
    {
        var animals = new List<Animal>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var animalInfo = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var foodInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var animalType = animalInfo[0];
            var foodType = foodInfo[0];
            var foodQuantity = int.Parse(foodInfo[1]);

            if (animalType == "Hen")
            {
                var hen = new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                hen.ProduceSound();
                hen.Eat(foodQuantity);
                animals.Add(hen);
            }
            else if (animalType == "Mouse")
            {
                var mouse = new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                mouse.ProduceSound();
                if (mouse.FavouriteFood.Contains(foodType))
                {
                    mouse.Eat(foodQuantity);
                }
                else
                {
                    NotFavouriteFood(animalType, foodType);
                }
                animals.Add(mouse);
            }
            else if (animalType == "Cat")
            {
                var cat = new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                cat.ProduceSound();

                if (cat.FavouriteFood.Contains(foodType))
                {
                    cat.Eat(foodQuantity);
                }
                else
                {
                    NotFavouriteFood(animalType, foodType);
                }
                animals.Add(cat);
            }
            else if (animalType == "Tiger")
            {
                var tiger = new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                tiger.ProduceSound();
                if (tiger.FavouriteFood.Contains(foodType))
                {
                    tiger.Eat(foodQuantity);
                }
                else
                {
                    NotFavouriteFood(animalType, foodType);
                }
                animals.Add(tiger);
            }
            else if (animalType == "Dog")
            {
                var dog = new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                dog.ProduceSound();
                if (dog.FavouriteFood.Contains(foodType))
                {
                    dog.Eat(foodQuantity);
                }
                else
                {
                    NotFavouriteFood(animalType, foodType);
                }
                animals.Add(dog);
            }
            else if (animalType == "Owl")
            {
                var owl = new Owl(animalInfo[1],double.Parse(animalInfo[2]),double.Parse(animalInfo[3]));
                owl.ProduceSound();
                if (owl.FavouriteFood.Contains(foodType))
                {
                    owl.Eat(foodQuantity);
                }
                else
                {
                    NotFavouriteFood(animalType, foodType);
                }
                animals.Add(owl);
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static void NotFavouriteFood(string animalType, string foodType)
    {
        Console.WriteLine($"{animalType} does not eat {foodType}!");
    }
}