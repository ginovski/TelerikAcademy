using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your age:");
        int age = int.Parse(Console.ReadLine());
        int result = age + 10;
        Console.WriteLine("Your age after ten years will be:" + result);
    }
}

