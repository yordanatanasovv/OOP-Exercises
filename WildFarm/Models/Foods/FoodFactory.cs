﻿using System;
using System.Collections.Generic;
using System.Text;

namespace zad3.Models.Foods
{
    public static class FoodFactory
    {
        public static Food CreateFood(params string[] foodArgs)
        {
            string type = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            if (type == nameof(Fruit))
            {
                return new Fruit(quantity);
            }
            else if (type == nameof(Meat))
            {
                return new Meat(quantity);
            }
            else if (type == nameof(Seeds))
            {
                return new Seeds(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                return new Vegetable(quantity);
            }

            return null;
        }
    }
}
