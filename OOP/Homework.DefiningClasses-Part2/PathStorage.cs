namespace Homework.DefiningClasses_Part2
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        private static string filePath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\points_path.txt");

        public static void Write(Path path)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    ReadPath(sw, path);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    ReadPath(sw, path);
                }
            }
        }

        public static void Read(Path path)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = string.Empty;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] tmp = new string[3];
                    double x, y, z;
                    tmp = str.Split(',');
                    x = double.Parse(tmp[0].Substring(2));
                    y = double.Parse(tmp[1].Substring(3));
                    z = double.Parse(tmp[2].Substring(3));
                    Point3D point = new Point3D(x, y, z);
                    path.Sequence.Add(point);                  
                }
            }
        }

        internal static void ReadPath(StreamWriter sw, Path path)
        {
            foreach (var point in path.Sequence)
            {
                sw.WriteLine(point.ToString());
            }
        }
    }
}