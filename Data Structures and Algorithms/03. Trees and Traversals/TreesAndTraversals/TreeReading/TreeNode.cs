namespace TreeReading
{
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        public T Value { get; set; }

        public TreeNode<T> Parent { get; set; }

        public List<TreeNode<T>> Children { get; set; }

        public TreeNode()
        {
            this.Children = new List<TreeNode<T>>();
        }

        public TreeNode(T value)
            : this()
        {
            this.Value = value;
        }
    }
}