using System.Collections.Generic;

namespace _03_WildFarm.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food, int pieces)
        {
            this.Weight += 0.35 * pieces;
            this.Pieces += pieces;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
