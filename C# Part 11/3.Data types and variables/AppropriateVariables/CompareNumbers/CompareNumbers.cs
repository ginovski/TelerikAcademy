using System;


class CompareNumbers
{
    static void Main(string[] args)
    {
        //Comparing numbers with precision 0.0000001 with variable type float
        float number1 = 5.0000005f;
        float number2 = 5.0000003f;
        bool compare = number1 == number2;
        Console.WriteLine(compare); //True
        Console.WriteLine();

        //Comparing numbers with precision 0.0000001 with variable type double
        double num1 = 5.0000005;
        double num2 = 5.0000003;
        bool compareAgain = num1 == num2;
        Console.WriteLine(compareAgain);
        Console.WriteLine();
    }
}

