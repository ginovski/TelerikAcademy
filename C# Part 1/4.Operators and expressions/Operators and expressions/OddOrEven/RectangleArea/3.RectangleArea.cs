using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        double width = int.Parse(Console.ReadLine());
        double height = int.Parse(Console.ReadLine());
        double rectangleArea = width * height;

        Console.WriteLine("The area of the rectangle is = {0}", rectangleArea);
    }
}

