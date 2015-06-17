using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write coefficients of the equation ax2+bx+c=0");
        Console.Write("a= ");
        string input = Console.ReadLine();
        double a = double.Parse(input);

        Console.Write("b= ");
        input = Console.ReadLine();
        double b = double.Parse(input);

        Console.Write("c= ");
        input = Console.ReadLine();
        double c = double.Parse(input);

        double D = b * b - 4 * a * c;
        double x1 = (-b + Math.Sqrt(D)) / 2 * a;
        double x2 = (-b - Math.Sqrt(D)) / 2 * a;

        if (D > 0)
        {
            Console.WriteLine("The equation has 2 roots: X1 = {0:0} and X2 = {1:0}", x1, x2);
        }
        else if (D == 0)
        {
            Console.WriteLine("The equation has 1 root: X = {0:0}", x1);
        }
        else
        {
            Console.WriteLine("The equation doesn't have roots");
        }
    }
}

