using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsuption = fuelConsumption;
        }

        public virtual double FuelQuantity { get; set; }

        public virtual double FuelConsuption { get; set; }

        public string Drive(double distance)
        {
            return $"{GetType().Name} travelled {distance} km";
        }

        public string Refuel()
        {
            return $"{GetType().Name} needs refueling";
        }
 
    }
}
