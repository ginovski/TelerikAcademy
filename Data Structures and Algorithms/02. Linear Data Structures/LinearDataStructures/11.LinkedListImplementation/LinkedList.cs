namespace LinkedListImplementation
{
    using System.Collections;

    public class LinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        private ListItem<T> firstElement;
        private ListItem<T> lastElement;

        public void AddLast(T item)
        {
            var newItem = new ListItem<T>()
            {
                Value = item
            };

            if (this.firstElement == null)
            {
                this.firstElement = newItem;
                this.lastElement = newItem;
            }
            else
            {
                this.lastElement.NextItem = newItem;
                this.lastElement = newItem;
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var current = this.firstElement;

            while (current != null)
            {
                yield return current.Value;

                current = current.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}