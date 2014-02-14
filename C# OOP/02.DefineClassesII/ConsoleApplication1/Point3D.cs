using System;
using System.Text;

namespace Points3D
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D pointO = new Point3D (0, 0, 0);
        public static Point3D PointO
        {
            get { return pointO; }
        }

        public Point3D(double x, double y, double z) :this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Point: ({0}, {1}, {2})", this.X, this.Y, this.Z));
            return sb.ToString();
        }
    }
}
