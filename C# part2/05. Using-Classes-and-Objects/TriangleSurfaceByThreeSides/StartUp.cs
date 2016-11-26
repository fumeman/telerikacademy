using System;

namespace TriangleSurfaceByThreeSides
{
    class Traingle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Surface { get; set; }
        

        public void GetSurface()
        {
            double s = (SideA + SideB + SideC) / 2;
            Surface = Math.Pow((s * (s - SideA) * (s - SideB) * (s - SideC)), 0.5);
        }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            Traingle T = new Traingle();

            T.SideA = double.Parse(Console.ReadLine());
            T.SideB = double.Parse(Console.ReadLine());
            T.SideC = double.Parse(Console.ReadLine());

            T.GetSurface();

            Console.WriteLine("{0:F}", T.Surface);
        }
    }
}
