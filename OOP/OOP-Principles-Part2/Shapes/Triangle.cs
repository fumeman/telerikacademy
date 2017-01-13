﻿namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get;
            private set;
        }

        public double Height
        {
            get;
            private set;
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
