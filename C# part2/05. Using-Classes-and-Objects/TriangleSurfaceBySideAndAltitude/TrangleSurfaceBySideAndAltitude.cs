using System;

namespace TriangleSurfaceBySideAndAltitude
{
    class Traingle
    {
        public double Side { get; set; }
        public double Altitude { get; set; }
        public double Surface { get; set; }

        public void GetSurface()
        {
            Surface = Side * Altitude / 2;
        }

        public void GetSide()
        {
            Side = 2 * (Surface / Altitude);
        }

        public void GetAltitude()
        {
            Altitude = 2 * ( Surface / Side );
        }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            Traingle T = new Traingle();

            T.Side = double.Parse(Console.ReadLine());
            T.Altitude = double.Parse(Console.ReadLine());

            T.GetSurface();
            
            Console.WriteLine("{0:F}", T.Surface);
        }
    }
}
