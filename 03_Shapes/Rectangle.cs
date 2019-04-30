﻿namespace _03_Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle()
        {
        }

        public double Height { get => this.height; private set => this.height = value; }
        public double Width { get => this.width; private set => this.width = value; }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Height + 2 * this.Width;
        }

        public override string Draw()
        {
            return base.Draw()+this.GetType().Name;
        }
    }
}
