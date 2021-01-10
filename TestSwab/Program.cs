using System;
using System.Collections.Generic;

public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        Node currentRoot = root;
        //while(true)
        {
            if (currentRoot.Value == value)
                return true;

            if (currentRoot.Value < value)
            {
                if (currentRoot.Right != null)
                    //currentRoot = currentRoot.Right;
                    return Contains(currentRoot.Right, value);
                else
                    return false;
            }

            if (currentRoot.Value > value)
            {
                if (currentRoot.Left != null)
                    //currentRoot = currentRoot.Left;
                    return Contains(currentRoot.Left, value);
                else
                    return false;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 1));
    }
}