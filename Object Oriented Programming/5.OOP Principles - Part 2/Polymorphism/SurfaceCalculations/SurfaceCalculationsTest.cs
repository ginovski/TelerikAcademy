namespace SurfaceCalculations
{
    using System;

    public class SurfaceCalculationsTest
    {
        public static void Main()
        {
            Shape[] figures = new Shape[]
            {
                new Triangle(5, 10),
                new Rectangle(15, 20),
                new Circle(5)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.CalculateSurface());
            }
        }
    }
}
