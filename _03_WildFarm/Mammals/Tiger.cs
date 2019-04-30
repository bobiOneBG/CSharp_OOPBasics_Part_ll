namespace _03_WildFarm.Mammals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food, int pieces)
        {
            if (food.GetType().Name == "Meat")
            {
                this.Weight += 1 * pieces;
                this.Pieces += pieces;
            }

            else
            {
                base.Eat(food, pieces);
            }
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
