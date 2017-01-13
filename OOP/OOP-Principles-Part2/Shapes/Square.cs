namespace Shapes
{
    public class Square : Shape
    {
        public Square(double height, double width)
        {
            if (width == height)
            {
                this.Height = height;
                this.Width = width;
            }
            else
            {
                throw new System.Exception("Height not equal to width!");
            }
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
            return this.Width * this.Height;
        }
    }
}
