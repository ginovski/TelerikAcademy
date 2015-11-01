//Write a program to read the tree and find:

//the root node
//all leaf nodes
//all middle nodes
//the longest path in the tree
namespace TreeReading
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        private static TreeNode<int> FindRoot(TreeNode<int>[] nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Parent == null)
                {
                    return node;
                }
            }

            throw new ArgumentException("Tree has no root");
        }

        private static List<TreeNode<int>> FindLeafs(TreeNode<int>[] nodes)
        {
            var leaves = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leaves.Add(node);
                }
            }

            return leaves;
        }

        private static List<TreeNode<int>> FindMiddleNodes(TreeNode<int>[] nodes)
        {
            var middleNodes = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count > 0 && node.Parent != null)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(TreeNode<int> node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int longestPathLength = 0;
            foreach (var child in node.Children)
            {
                int childLongest = FindLongestPath(child);
                if (childLongest > longestPathLength)
                {
                    longestPathLength = childLongest;
                }
            }

            return longestPathLength + 1;
        }

        public static void Main()
        {
            string input = @"
7
2 4
3 2
5 0
3 5
5 6
5 1";
            Console.SetIn(new StringReader(input.Trim()));
            int n = int.Parse(Console.ReadLine());
            var nodes = new TreeNode<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                var parentAndChild = Console.ReadLine().Split(' ');
                int parent = int.Parse(parentAndChild[0]);
                int child = int.Parse(parentAndChild[1]);

                nodes[parent].Children.Add(nodes[child]);

                nodes[parent].Value = parent;
                nodes[child].Value = child;
                nodes[child].Parent = nodes[parent];
            }

            var root = FindRoot(nodes);
            Console.WriteLine("Root of the tree is: {0}", root.Value);

            var leaves = FindLeafs(nodes);
            Console.Write("Leaves of the tree are: ");
            foreach (var leaf in leaves)
            {
                Console.Write("{0}, ", leaf.Value);
            }

            Console.WriteLine();

            var middleNodes = FindMiddleNodes(nodes);
            Console.Write("Middle nodes of the tree are: ");
            foreach (var middleNode in middleNodes)
            {
                Console.Write("{0}, ", middleNode.Value);
            }

            Console.WriteLine();

            int longestPathLength = FindLongestPath(root);
            Console.WriteLine("Longest path has length of: {0}", longestPathLength);
        }
    }
}