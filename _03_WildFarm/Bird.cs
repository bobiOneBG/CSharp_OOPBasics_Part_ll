namespace _03_WildFarm
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {WingSize}, {this.Weight}, {this.Pieces}]";
        }
    }
}
