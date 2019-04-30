namespace _03_WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; set; }
        public int Pieces { get;set; }

        public abstract string ProduceSound();

        public virtual void Eat(Food food, int pieces)
        {
            System.Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
