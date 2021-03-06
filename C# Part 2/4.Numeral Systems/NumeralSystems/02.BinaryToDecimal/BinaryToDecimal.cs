﻿using System;

class BinaryToDecimal
{
    static int Pow(int number, int pow)
    {
        int result = 1;
        for (int i = 0; i < pow; i++)
        {
            result *= number;
        }
        return result;
    }
    static int ConvertBinaryToDecimal(string number)
    {
        int numberBase = 2;
        int pow = number.Length - 1;
        int digit = 0;
        int result = 0;
        for (int index = 0; index < number.Length; index++)
        {
            digit = int.Parse(number[index].ToString());
            result += digit * Pow(numberBase, pow);
            pow--;
        }
        return result;
    }
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int convertedNumber = ConvertBinaryToDecimal(number);
        Console.WriteLine(convertedNumber);
    }
}
