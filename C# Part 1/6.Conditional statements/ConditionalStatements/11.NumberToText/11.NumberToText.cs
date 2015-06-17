using System;

class NumberToText
{
    static void Main(string[] args)
    {
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);

        if (number >= 0 && number <= 999)
        {
            int ones = number % 10;
            number = number / 10;
            int tens = number % 10;
            number /= 10;
            int hundreds = number % 10;

            switch (hundreds)
            {
                case 1:
                    Console.Write("One Hundred ");
                    break;
                case 2:
                    Console.Write("Two Hundred ");
                    break;
                case 3:
                    Console.Write("Three Hundred ");
                    break;
                case 4:
                    Console.Write("Four Hundred ");
                    break;
                case 5:
                    Console.Write("Five Hundred ");
                    break;
                case 6:
                    Console.Write("Six Hundred ");
                    break;
                case 7:
                    Console.Write("Seven Hundred ");
                    break;
                case 8:
                    Console.Write("Eight Hundred ");
                    break;
                case 9:
                    Console.Write("Nine Hundred ");
                    break;
                case 0:
                    break;
            }
            switch (tens)
            {
                case 1:
                    if (hundreds == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("and ");
                    }
                    break;
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Fourty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
                case 0:
                    if (ones == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("and ");
                    }
                    break;
            }
            switch (ones)
            {
                case 1 :
                    if (tens == 1)
                    {
                        Console.WriteLine("Eleven");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("One");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("One");
                    }
                    else
                    {
                        Console.WriteLine("One");
                    }
                    break;
                case 2:
                    if (tens == 1)
                    {
                        Console.WriteLine("Twelve");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Two");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Two");
                    }
                    else
                    {
                        Console.WriteLine("Two");
                    }
                    break;
                case 3:
                    if (tens == 1)
                    {
                        Console.WriteLine("Thirteen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Three");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Three");
                    }
                    else
                    {
                        Console.WriteLine("Three");
                    }
                    break;
                case 4:
                    if (tens == 1)
                    {
                        Console.WriteLine("Fourteen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Four");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Four");
                    }
                    else
                    {
                        Console.WriteLine("Four");
                    }
                    break;
                case 5:
                    if (tens == 1)
                    {
                        Console.WriteLine("Fifteen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Five");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Five");
                    }
                    else
                    {
                        Console.WriteLine("Five");
                    }
                    break;
                case 6:
                    if (tens == 1)
                    {
                        Console.WriteLine("Sixteen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Six");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Six");
                    }
                    else
                    {
                        Console.WriteLine("Six");
                    }
                    break;
                case 7:
                    if (tens == 1)
                    {
                        Console.WriteLine("Seventeen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Seven");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Seven");
                    }
                    else
                    {
                        Console.WriteLine("Seven");
                    }
                    break;
                case 8:
                    if (tens == 1)
                    {
                        Console.WriteLine("Eighteen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Eight");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Eight");
                    }
                    else
                    {
                        Console.WriteLine("Eight");
                    }
                    break;
                case 9:
                    if (tens == 1)
                    {
                        Console.WriteLine("Nineteen");
                    }
                    else if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Nine");
                    }
                    else if (tens == 0)
                    {
                        Console.WriteLine("Nine");
                    }
                    else
                    {
                        Console.WriteLine("Nine");
                    }
                    break;
                case 0:
                    if (tens == 0 && hundreds == 0)
                    {
                        Console.WriteLine("Zero");
                    }
                    else
                    {
                        break;
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}

