using System;

class isInTheCircle
{
    static void Main()
    {
        decimal pointX = decimal.Parse(Console.ReadLine());
        decimal pointY = decimal.Parse(Console.ReadLine());
        decimal resultX = pointX * pointX;
        decimal resultY = pointY * pointY;

        decimal endResult = resultX + resultY;
        decimal radius = 5;

        bool isWithinCircle = endResult < radius * radius;
        Console.WriteLine(isWithinCircle);
    }
}

