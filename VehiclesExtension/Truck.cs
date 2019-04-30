namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption = fuelConsumption + 1.6;
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
    }
}
