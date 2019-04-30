namespace _01_Vehicles
{
    using System;

    public abstract class Vehicle
    {

        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity { get => this.fuelQuantity; protected set => this.fuelQuantity = value; }
        public double FuelConsumption { get => this.fuelConsumption; protected set => this.fuelConsumption = value; }

        public void Drive(double distance)
        {
            if (this.FuelConsumption * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
