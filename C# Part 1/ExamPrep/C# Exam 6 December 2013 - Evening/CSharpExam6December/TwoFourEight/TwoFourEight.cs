using System;

class twoFourEight
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        ulong A = uint.Parse(input);

        input = Console.ReadLine();
        ulong B = uint.Parse(input);

        input = Console.ReadLine();
        ulong C = uint.Parse(input);

        ulong R = 0;

        switch (B)
        {
            case 2:
                R = A % C;
                break;
            case 4:
                R = A + C;
                break;
            case 8:
                R = A * C;
                break;
            case 0:
                break;
        }


        if (R % 4 == 0)
        {
            Console.WriteLine(R / 4);
        }

        else
        {
            Console.WriteLine(R % 4);
        }

        Console.WriteLine(R);
    }
}

