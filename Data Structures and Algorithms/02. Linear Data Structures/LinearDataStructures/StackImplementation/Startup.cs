// Implement the ADT stack as auto-resizable array.
// Resize the capacity on demand (when no space is available to add / insert a new element).
namespace StackImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Push(i + 1);
            }

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}