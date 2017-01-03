namespace Homework.DefiningClasses_Part2
{
    using System;

    class Startup
    {
        public static void Main()
        {
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(4, 7.5, 8);

            Console.WriteLine(point1.ToString());
            Console.WriteLine(Point3D.PointO);
            Console.WriteLine(DistanceBetweenTwoPoints.Calculate(point1, Point3D.PointO));
            Console.WriteLine(DistanceBetweenTwoPoints.Calculate(point1, point2));
            Console.WriteLine(DistanceBetweenTwoPoints.Calculate(point2, Point3D.PointO));

            Path pointsPath1 = new Path();
            ////pointsPath1.Sequence.Add(point1);
            ////pointsPath1.Sequence.Add(point2);
            ////pointsPath1.Sequence.Add(Point3D.PointO);

            Path pointsPath2 = new Path();
            pointsPath2.Sequence.Add(point2);
            pointsPath2.Sequence.Add(Point3D.PointO);
            pointsPath2.Sequence.Add(point1);

            ////PathStorage.Write(pointsPath2);

            ////PathStorage.Read(pointsPath1);

            ////foreach (var point in pointsPath1.Sequence)
            ////{
            ////    Console.WriteLine(point.ToString());
            ////}

            GenericList<int> list = new GenericList<int>();
            list.Add(4);
            list.Add(6);
            list.Add(6);
            list.Add(1);
            list.Add(8);
            Console.WriteLine(list.ToString());
            Console.WriteLine(list);
            Console.WriteLine(list.Count);

            Console.WriteLine(list.GetByIndex(3));
            list.RemoveByIndex(3);
            Console.WriteLine(list.GetByIndex(3));

            Console.WriteLine(list.ToString());

            list.InsertAtPosition(4, 4);

            Console.WriteLine(list.ToString());
        }
    }
}
