using System;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class Traingle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Angle { get; set; }
        public double Surface { get; set; }


        public void GetSurface()
        {
            Surface = (Math.Sin(Math.PI * Angle / 180.0) * SideA * SideB) / 2;
        }
    }

    class StartUp
    {
        static void Main()
        {
            Traingle T = new Traingle();

            T.SideA = double.Parse(Console.ReadLine());
            T.SideB = double.Parse(Console.ReadLine());
            T.Angle = double.Parse(Console.ReadLine());

            T.GetSurface();

            Console.WriteLine("{0:F}", T.Surface);
        }
    }
}
