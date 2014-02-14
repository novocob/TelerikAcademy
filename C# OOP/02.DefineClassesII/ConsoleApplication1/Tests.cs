using System;

namespace Points3D
{
    class Tests
    {
        static void Main()
        {
            // Test creating a new instance of Point3D
            Point3D myPoint = new Point3D(2, 2, 2);

            // Test the override of ToString()
            Console.WriteLine(myPoint.ToString());

            // Test the static property PointO
            Console.WriteLine(Point3D.PointO.ToString());

            // Test the calculating of distance between two points
            Console.WriteLine("The distance between {0} and {1} is: {2}",myPoint, Point3D.PointO, Distance3D.CalcDistance3D(myPoint, Point3D.PointO));
            
        }
    }
}
