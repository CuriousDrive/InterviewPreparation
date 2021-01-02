using System;

namespace TestDomePractice
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value, Node left, Node right)
        {
            Value = value;
            if (left.Value <= value)
                Left = left;
            if (right.Value > value)
                Right = right;
            if (right.Value <= value)
                Left = right;
            if (left.Value > value)
                Right = left;
        }
    }

    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            throw new NotImplementedException("Waiting to be implemented.");
        }

        public static void Main2(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));
        }
    }
}
