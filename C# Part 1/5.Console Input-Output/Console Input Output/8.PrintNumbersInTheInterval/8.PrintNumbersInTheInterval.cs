using System;

class PrintNumbersInTheInterval
{
    static void Main(string[] args)
    {
        string numberInput = Console.ReadLine();
        int number = int.Parse(numberInput);
        
        for (int i = 1; i < number; i++)
        {
            Console.Write(i + " ");
           
        }
         Console.WriteLine();
    }
}
