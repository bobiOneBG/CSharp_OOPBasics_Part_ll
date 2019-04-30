namespace _03_WildFarm.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food, int pieces)
        {
            if (food.GetType().Name == "Vegetable"||food.GetType().Name=="Fruit")
            {
                this.Weight += 0.1 * pieces;
                this.Pieces += pieces;
            }

            else
            {
                base.Eat(food, pieces);
            }
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{ this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.Pieces}]";
        }
    }
}
