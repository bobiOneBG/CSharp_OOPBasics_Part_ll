namespace VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {

        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.ValidateQuantity(fuelQuantity, tankCapacity);
        }

        private void ValidateQuantity(double fuelQuantity, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }

            else
            {
                this.FuelQuantity = fuelQuantity;
            }
        }

        public double FuelConsumption { get => this.fuelConsumption; protected set => this.fuelConsumption = value; }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            protected set
            {
                if (value > this.TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {value} fuel in the tank");
                }

                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double TankCapacity { get; private set; }

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
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else
            {
                this.FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
