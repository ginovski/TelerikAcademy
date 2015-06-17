using System;

class CalculatingTheSum
{
    static void Main(string[] args)
    {
        //1 + 1/2 - 1/3 + 1/4 - 1/5
        decimal counter = 2m;
        decimal sum = 1m;
        int sign = 1;
        while (1/counter > 0.001m)
        {
            sum += (1 / counter) * sign;
            sign *= (-1);
            counter++;

        }
        Console.WriteLine("The sum is equal to {0:0.000}", sum);
    }
}

