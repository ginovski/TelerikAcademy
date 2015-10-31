// We are given numbers N and M and the following operations:
// N = N+1
// N = N+2
// N = N*2
// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
// Hint: use a queue.
namespace ShortestOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int start = 5;
            int end = 16;

            var operations = new Queue<int>();

            while (start <= end)
            {
                operations.Enqueue(end);

                if (end / 2 >= start)
                {
                    if (end % 2 == 0)
                    {
                        end /= 2;
                    }
                    else
                    {
                        end -= 1;
                    }
                }
                else
                {
                    if (end - 2 >= start)
                    {
                        end -= 2;
                    }
                    else
                    {
                        end -= 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", operations.Reverse()));
        }
    }
}