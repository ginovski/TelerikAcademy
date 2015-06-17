using System;

class NightmareOnCodeStreet
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int result = 0;
        int numbers = 0;
        int sum = 0;
        for (int i = 1; i < input.Length; i += 2)
        {
            numbers = (int)input[i];
            switch (numbers)
            {
                case 48:
                    result += 0;
                    sum++;
                    break;
                case 49:
                    result += 1;
                    sum++;
                    break;
                case 50:
                    result += 2;
                    sum++;
                    break;
                case 51:
                    result += 3;
                    sum++;
                    break;
                case 52:
                    result += 4;
                    sum++;
                    break;
                case 53:
                    result += 5;
                    sum++;
                    break;
                case 54:
                    result += 6;
                    sum++;
                    break;
                case 55:
                    result += 7;
                    sum++;
                    break;
                case 56:
                    result += 8;
                    sum++;
                    break;
                case 57:
                    result += 9;
                    sum++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("{0} {1}", sum, result);
    }
}

