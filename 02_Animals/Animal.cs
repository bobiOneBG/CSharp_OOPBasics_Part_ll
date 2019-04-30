﻿namespace _02_Animals
{
    public class Animal
    {
        protected Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }
        
        public string FavouriteFood { get; private set; }
        public string Name { get; private set; }

        public virtual  string  ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}