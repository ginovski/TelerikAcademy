using System;

class RadiusOfACircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle");
        string radiusInput = Console.ReadLine();
        double radius = double.Parse(radiusInput);
        const double Pi = 3.14;
        double area = Pi * radius * radius;
        double perimeter = 2 * Pi * radius;

        Console.WriteLine("The area of the circle is = {0}, and the perimeter is = {1}", area, perimeter);
    }
}

