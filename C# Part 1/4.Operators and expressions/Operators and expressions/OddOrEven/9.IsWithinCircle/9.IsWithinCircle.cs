using System;

class IsWithinCircle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 4;
        double centerX = 1;
        double centerY = 1;
        if ((((x - centerX) * (x - centerX)) + ((y - centerY) * (y - centerY)) <= (radius * radius)) &&
           ((x >= -1 && x <= 5) && (y <= 1 && x >= -1)))
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and in rectangle",
                x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out within the circle K((1,1),3) or it is out of rectangle",
                x, y);     
        }
    }
}

