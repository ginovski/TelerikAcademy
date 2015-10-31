// Implement the ADT queue as dynamic linked list.
// Use generics(LinkedQueue<T>) to allow storing different data types in the queue.
namespace LinkedQueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new LinkedQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(i + 1);
            }

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }
        }
    }
}