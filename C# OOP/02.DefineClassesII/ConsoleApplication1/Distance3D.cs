using System;

namespace Points3D
{
    public static class Distance3D
    {
        public static double CalcDistance3D(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                                        (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.X) +
                                        (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
            return distance;
        }
    }
}
