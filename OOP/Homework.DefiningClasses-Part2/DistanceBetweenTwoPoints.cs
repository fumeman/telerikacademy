namespace Homework.DefiningClasses_Part2
{
    using System;

    public static class DistanceBetweenTwoPoints
    {
        public static double Calculate(Point3D pointA, Point3D pointB)
        {
            double result;
            double x1 = pointA.X;
            double y1 = pointA.Y;
            double z1 = pointA.Z;
            double x2 = pointB.X;
            double y2 = pointB.Y;
            double z2 = pointB.Z;
            result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return result;
        }
    }
}
