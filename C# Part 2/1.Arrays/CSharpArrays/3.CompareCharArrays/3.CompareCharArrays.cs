using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        int charLengthOne = int.Parse(Console.ReadLine());
        int charLengthTwo = int.Parse(Console.ReadLine());

        char[] charArrayOne = new char[charLengthOne];
        char[] charArrayTwo = new char[charLengthTwo];
        bool equal = true;

        if (charLengthOne == charLengthTwo)
        {
            for (int i = 0; i < charArrayOne.Length; i++)
            {
                charArrayOne[i] = char.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < charArrayTwo.Length; i++)
            {
                charArrayTwo[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < charArrayOne.Length; i++)
            {
                if (charArrayOne[i] != charArrayTwo[i])
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
