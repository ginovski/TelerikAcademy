using System;

class trapezoidArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double trapezoidArea = ((a + b) / 2) * h;
      
        Console.WriteLine("The area of the trapezoid is = {0}", trapezoidArea);
        Console.Clear();
        
    }
}

