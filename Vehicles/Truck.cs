using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsuption = fuelConsumption;
        }

        public override double FuelConsuption
        {
            get => base.FuelConsuption;
            set => base.FuelConsuption = value + 1.6;
        }

        public override double FuelQuantity
        {
            get => base.FuelQuantity;
            set => base.FuelQuantity = value * (95/100);
        }
    }
}
