namespace Shapes
{
    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        public abstract double CalculateSurface();
    }
}
