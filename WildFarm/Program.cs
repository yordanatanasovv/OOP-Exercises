using System;
using System.Collections.Generic;
using zad3.Models.Animals;
using zad3.Models.Foods;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (input != "End")
            {
                string[] animalArgs = input
                    .Split();

                Animal animal = AnimalFactory.CreateAnimal(animalArgs);
                animals.Add(animal);

                string[] foodArgs = Console.ReadLine()
                    .Split();

                Food food = FoodFactory.CreateFood(foodArgs);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
