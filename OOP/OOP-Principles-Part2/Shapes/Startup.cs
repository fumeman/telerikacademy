namespace Shapes
{
    using System;

    class Startup
    {
        static void Main()
        {
            IShape[] arr = { new Square(5, 5), new Triangle(10, 20), new Rectangle(10, 20) };

            foreach (Shape shape in arr)
            {
                Console.WriteLine(shape.GetType());
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
