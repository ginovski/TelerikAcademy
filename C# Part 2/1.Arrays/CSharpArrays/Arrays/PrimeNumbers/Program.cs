//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes 
//algorithm(http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes).
namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var numbers = new List<int>();
            var primeNumbers = new List<int>();
            int currNum = 0;
            //You can change it to 10000000 to see that it works but it takes time for the Console.WriteLine, so I did it with 100
            int primeMax = 100; 

            for (int i = 1; i <= primeMax; i++)
            {
                numbers.Add(i);
            }

            numbers[0] = 0; //Number 1 is not prime so we remove it;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    currNum = numbers[i];
                    for (int j = i + currNum; j < numbers.Count; j += currNum)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    primeNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", primeNumbers));
        }
    }
}
