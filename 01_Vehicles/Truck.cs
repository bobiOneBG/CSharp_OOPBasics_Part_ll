namespace _01_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption = fuelConsumption + 1.6;
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
    }
}
