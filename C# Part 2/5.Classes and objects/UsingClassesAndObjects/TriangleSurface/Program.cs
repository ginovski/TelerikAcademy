//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
namespace TriangleSurface
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double h = 4;
            double angleAlpha = 90;

            double surfaceBySideAndAltitude = CalculateTriangleSurfaceBySideAndAltitude(a, h);
            double surfaceByThreeSides = CalculateTriangleSurfaceByThreeSides(a, b, c);
            double surfaceByThreeSidesAndAngleBetween = CalculateTriangleSurfaceBySidesAndAngle(a, b, angleAlpha);

            Console.WriteLine("Surface by side and altitude: {0}", surfaceBySideAndAltitude);
            Console.WriteLine("Surface by three sides: {0}", surfaceByThreeSides);
            Console.WriteLine("Surface by three sides and angle: {0}", surfaceByThreeSidesAndAngleBetween);


        }

        private static double CalculateTriangleSurfaceBySidesAndAngle(double sideOne, double sideTwo, double angle)
        {
            return (sideOne * sideTwo * Math.Sin((Math.PI * angle) / 180)) / 2;
        }

        private static double CalculateTriangleSurfaceByThreeSides(double a, double b, double c)
        {
            //Heron formula
            return Math.Sqrt((a + b - c) * (a - b + c) * (-a + b + c) * (a + b + c)) / 4;
        }

        private static double CalculateTriangleSurfaceBySideAndAltitude(double side, double altitude)
        {
            return (side * altitude) / 2;
        }


    }
}
