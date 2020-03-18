using System;
using System.Collections.Generic;
using System.Text;
using zad3.Models.Foods;

namespace zad3.Models.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }   

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract string ProduceSound();

        public abstract void Eat(Food food);

        protected void BaseEat(Food food, List<string> eatableFood, double gainValue)
        {
            string foodType = food.GetType().Name;

            if (!eatableFood.Contains(foodType))
            {
                throw new Exception($"{this.GetType().Name} does not eat {foodType}!");
            }

            this.Weight += food.Quantity * gainValue;
            this.FoodEaten += food.Quantity;
        }
        
    }
}
