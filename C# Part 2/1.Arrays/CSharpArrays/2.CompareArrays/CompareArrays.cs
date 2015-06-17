using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int[] firstArray = new int[numberOne];
        int[] secondArray = new int[numberTwo];
        bool equal = true;
        if (firstArray.Length == secondArray.Length)
        {


            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }
            Console.WriteLine("Arrays are equal? ----> {0}", equal);
        }
        else
        {
            Console.WriteLine("Arrays are equal? ----> {0}", equal);
        }
        
    }
}

