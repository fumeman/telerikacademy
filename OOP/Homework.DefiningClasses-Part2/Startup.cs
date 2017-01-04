namespace Homework.DefiningClasses_Part2
{
    using System;

    class Startup
    {
        public static void Main()
        {
            ////Point3D

            Console.WriteLine("Point3D");
            Console.WriteLine("-------");
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(4, 7.5, 8);

            Console.WriteLine(point1.ToString());
            Console.WriteLine(Point3D.PointO);
            Console.WriteLine(DistanceBetweenTwoPoints.Calculate(point1, Point3D.PointO));
            Console.WriteLine(DistanceBetweenTwoPoints.Calculate(point1, point2));
            Console.WriteLine(DistanceBetweenTwoPoints.Calculate(point2, Point3D.PointO));

            //Path
            Console.WriteLine();
            Console.WriteLine("Path");
            Console.WriteLine("----");

            Path pointsPath1 = new Path();
            ////pointsPath1.Sequence.Add(point1);
            ////pointsPath1.Sequence.Add(point2);
            ////pointsPath1.Sequence.Add(Point3D.PointO);

            Path pointsPath2 = new Path();
            pointsPath2.Sequence.Add(point2);
            pointsPath2.Sequence.Add(Point3D.PointO);
            pointsPath2.Sequence.Add(point1);

            PathStorage.Write(pointsPath2);

            PathStorage.Read(pointsPath1);

            foreach (var point in pointsPath1.Sequence)
            {
                Console.WriteLine(point.ToString());
            }

            ////GenericList
            Console.WriteLine();
            Console.WriteLine("GenericList");
            Console.WriteLine("-----------");

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
            Console.WriteLine(list[2]);

            Console.WriteLine(list.Min());

            ////Matrix
            Console.WriteLine();
            Console.WriteLine("Matrix");
            Console.WriteLine("------");

            Matrix<int> arr = new Matrix<int>(2, 2);

            arr[0, 0] = 0;
            arr[0, 1] = 1;
            arr[1, 0] = 2;
            arr[1, 1] = 3;

            Matrix<int> arr2 = new Matrix<int>(2, 2);

            arr2[0, 0] = 3;
            arr2[0, 1] = 2;
            arr2[1, 0] = 1;
            arr2[1, 1] = 0;

            Matrix<int> arr3 = arr + arr2;

            Console.WriteLine(arr3.ToString());

            if (arr)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            //Version
            Console.WriteLine();
            Console.WriteLine("Version");
            Console.WriteLine("-------");

            Type type = typeof(Path);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                AttributeVersion attributeVersion = (AttributeVersion)attribute;
                Console.WriteLine("Version {0}", attributeVersion.Version);
            }
        }
    }
}
