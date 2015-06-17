using System;

namespace Point3D
{
    public class TestPoint
    {
        static void Main(string[] args)
        {
            Point pt = new Point(25, 20, 30);
            Point anotherPt = new Point(20, 15, 25);
            Path storage = new Path();

            storage.Add(pt);
            storage.Add(anotherPt);
        }
    }
}
