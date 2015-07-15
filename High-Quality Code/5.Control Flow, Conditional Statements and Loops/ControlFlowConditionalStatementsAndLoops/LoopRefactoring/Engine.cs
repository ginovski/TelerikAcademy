// Refactor the following loop
namespace LoopRefactoring
{
    using System;

    public class Engine
    {
        public static void Main()
        {
            int[] numbers = new int[100];
            int expectedValue = 5;

            bool found = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0 && numbers[i] == expectedValue)
                {
                    found = true;
                    break;
                }

                Console.WriteLine(numbers[i]);
            }

            // More code here
            if (found)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

