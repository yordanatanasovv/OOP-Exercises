using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            :base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsuption = fuelConsumption;
        }

        public override double FuelConsuption
        {
            get => base.FuelConsuption;
            set
            {
                base.FuelConsuption = value + 0.9;
            }
        }
    }
}
