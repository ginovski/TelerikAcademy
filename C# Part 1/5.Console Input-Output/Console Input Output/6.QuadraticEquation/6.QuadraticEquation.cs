using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write coefficient a");
        string coefficientsInput = Console.ReadLine();
        double a = double.Parse(coefficientsInput);

        Console.WriteLine("Write coefficient b");
        coefficientsInput = Console.ReadLine();
        double b = double.Parse(coefficientsInput);

        Console.WriteLine("Write coefficient c");
        coefficientsInput = Console.ReadLine();
        double c = double.Parse(coefficientsInput);

        double D = (b * b) - (4 * a * c);
        double x1 = (-b + Math.Sqrt(D)) / 2 * a;
        double x2 = (-b - Math.Sqrt(D)) / 2 * a;

        Console.WriteLine("D is = {0}", D);
        Console.WriteLine("The result of the equation is:\n X1 = {0:0}\n X2 = {1:0}", x1, x2);
    }
}

