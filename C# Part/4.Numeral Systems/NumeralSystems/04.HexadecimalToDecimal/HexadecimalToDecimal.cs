using System;

class HexadecimalToDecimal
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
        int numberBase = 16;
        int pow = number.Length - 1;
        int digit = 0;
        int result = 0;
        for (int index = 0; index < number.Length; index++)
        {
            if (number[index] == 'A' || number[index] == 'a')
            {
                digit = 10;
            }
            else if (number[index] == 'B' || number[index] == 'b')
            {
                digit = 11;
            }
            else if (number[index] == 'C' || number[index] == 'c')
            {
                digit = 12;
            }
            else if (number[index] == 'D' || number[index] == 'd')
            {
                digit = 13;
            }
            else if (number[index] == 'E' || number[index] == 'e')
            {
                digit = 14;
            }
            else if (number[index] == 'F' || number[index] == 'f')
            {
                digit = 15;
            }
            else
            {
                digit = int.Parse(number[index].ToString());
            }
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
