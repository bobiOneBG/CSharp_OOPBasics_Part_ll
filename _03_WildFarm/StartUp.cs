namespace _03_WildFarm
{
    using _03_WildFarm.Birds;
    using _03_WildFarm.Foods;
    using _03_WildFarm.Mammals;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalInfo = input.Split();
                var foodInfo = Console.ReadLine().Split();

                var animalType = animalInfo[0];
                var animalName = animalInfo[1];
                var weight = double.Parse(animalInfo[2]);

                var foodType = foodInfo[0];
                var quantity = int.Parse(foodInfo[1]);
                Food food = null;
                switch (foodType)
                {
                    case "Fruit":
                        food = new Fruit(quantity);
                        break;
                    case "Meat":
                        food = new Meat(quantity);
                        break;
                    case "Seeds":
                        food = new Seeds(quantity);
                        break;
                    case "Vegetable":
                        food = new Vegetable(quantity);
                        break;
                    default:
                        Console.WriteLine("foodsProblem");
                        break;
                }

                if (animalType == "Owl" || animalType == "Hen")
                {
                    var wingSize = double.Parse(animalInfo[3]);

                    if (animalType == "Owl")
                    {
                        Bird owl = new Owl(animalName, weight, wingSize);

                        Console.WriteLine(owl.ProduceSound());

                        owl.Eat(food, quantity);

                        animals.Add(owl);
                    }

                    else if (animalType == "Hen")
                    {
                        Bird hen = new Hen(animalName, weight, wingSize);

                        Console.WriteLine(hen.ProduceSound());

                        hen.Eat(food, quantity);

                        animals.Add(hen);
                    }
                }

                else if (animalType == "Mouse" || animalType == "Dog")
                {
                    var livingRegion = animalInfo[3];

                    if (animalType == "Mouse")
                    {
                        Mammal mouse = new Mouse(animalName, weight, livingRegion);

                        Console.WriteLine(mouse.ProduceSound());

                        mouse.Eat(food, quantity);

                        animals.Add(mouse);
                    }

                    else if (animalType == "Dog")
                    {
                        Mammal dog = new Dog(animalName, weight, livingRegion);

                        Console.WriteLine(dog.ProduceSound());

                        dog.Eat(food, quantity);

                        animals.Add(dog);
                    }
                }

                else if (animalType == "Cat" || animalType == "Tiger")
                {
                    var livingRegion = animalInfo[3];
                    var breed = animalInfo[4];

                    if (animalType == "Cat")
                    {
                        Feline cat = new Cat(animalName, weight, livingRegion, breed);

                        Console.WriteLine(cat.ProduceSound());

                        cat.Eat(food, quantity);

                        animals.Add(cat);
                    }

                    else if (animalType == "Tiger")
                    {
                        Feline tiger = new Tiger(animalName, weight, livingRegion, breed);

                        Console.WriteLine(tiger.ProduceSound());

                        tiger.Eat(food, quantity);

                        animals.Add(tiger);
                    }
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
