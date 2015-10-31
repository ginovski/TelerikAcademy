// Implement the data structure linked list.

// Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).
// Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).
namespace LinkedListImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var list = new LinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i + 1);
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}