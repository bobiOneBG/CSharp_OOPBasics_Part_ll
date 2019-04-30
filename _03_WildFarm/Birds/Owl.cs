namespace _03_WildFarm.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food, int pieces)
        {
            if (food.GetType().Name=="Meat")
            {
                this.Weight += 0.25 * pieces;
                this.Pieces += pieces;
            }

            else
            {
                base.Eat(food, pieces);
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
