namespace _03_WildFarm.Mammals
{
    public class Cat : Feline

    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food, int pieces)
        {
            if (food.GetType().Name == "Meat"|| food.GetType().Name == "Vegetable")
            {
                this.Weight += 0.3 * pieces;
                this.Pieces += pieces;
            }

            else
            {
                base.Eat(food, pieces);
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
