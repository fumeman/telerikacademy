namespace Homework.DefiningClasses_Part2
{
    public struct Point3D
    {
        private static readonly Point3D O = new Point3D(0, 0, 0);
        
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D PointO
        {
            get
            {
                return O;
            }
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public override string ToString()
        {
            string result;
            result = string.Format(@"X={0}, Y={1}, Z={2}", this.X, this.Y, this.Z);
            return result;
        }
    }
}
