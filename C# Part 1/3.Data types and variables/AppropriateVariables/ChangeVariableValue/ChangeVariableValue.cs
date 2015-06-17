using System;

class ChangeVariableValue
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        //Printing the variables
        Console.WriteLine("First variable: {0}\nSecond variable: {1}", a, b);

        //Third variable
        int c;
        c = a;
        a = b;
        b = c;

        Console.WriteLine("First variable: {0}\nSecond variable: {1}", a, b);
    }
}

