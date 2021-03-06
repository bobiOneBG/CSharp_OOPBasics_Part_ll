﻿namespace _03_WildFarm.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food, int pieces)
        {
            if (food.GetType().Name == "Meat")
            {
                this.Weight += 0.4 * pieces;
                this.Pieces += pieces;
            }

            else
            {
                base.Eat(food, pieces);
            }
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
             return $"{ this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.Pieces}]";
        }
    }
}
