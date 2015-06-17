using System;

class NumbersToN
{
    static void Main(string[] args)
    {
        string maxValueInput = Console.ReadLine();
        int maxValue = int.Parse(maxValueInput);

        for (int i = 1; i < maxValue; i++)
        {
            if (((i % 7) == 0) && ((i % 3) == 0))
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

