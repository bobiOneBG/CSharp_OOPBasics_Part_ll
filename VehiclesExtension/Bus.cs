using System;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
        }

        public void ONAirConditioner()
        {
            this.FuelConsumption += 1.4;
        }

        public void OFFAirConditioner()
        {
            this.FuelConsumption -= 1.4;
        }
    }
}
