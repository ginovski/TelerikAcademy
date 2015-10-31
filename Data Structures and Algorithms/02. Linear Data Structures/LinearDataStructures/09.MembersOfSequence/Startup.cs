// We are given the following sequence:

// S1 = N;
// S2 = S1 + 1;
// S3 = 2* S1 + 1;
// S4 = S1 + 2;
// S5 = S2 + 1;
// S6 = 2* S2 + 1;
// S7 = S2 + 2;
// ...
// Using the Queue<T> class write a program to print its first 50 members for given N.
// Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
namespace MembersOfSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int firstMembersCount = 50;
            int n = int.Parse(Console.ReadLine());

            var members = new Queue<int>();
            members.Enqueue(n);
            for (int i = 0; i < firstMembersCount; i++)
            {
                int current = members.Dequeue();

                if (i == firstMembersCount - 1)
                {
                    Console.WriteLine(current);
                }
                else
                {
                    Console.Write(current + ", ");
                }

                members.Enqueue(current + 1);
                members.Enqueue(2 * current + 1);
                members.Enqueue(current + 2);
            }
        }
    }
}