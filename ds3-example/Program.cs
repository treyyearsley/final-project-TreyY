
using System;

public class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int data)
    {
        Data = data;
        Left = Right = null;
    }
}

public class BinarySearchTree
{
    private Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    // Method to insert a new node
    public void Insert(int data)
    {
        root = Insert(root, data);
    }

    // Method to insert a new node in BST
    private Node Insert(Node root, int data)
    {
        // If the tree is empty, return a new node
        if (root == null)
        {
            root = new Node(data);
            return root;
        }
        
        if (data < root.Data)
        {
            root.Left = Insert(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = Insert(root.Right, data);
        }
        
        return root;
    }

    
    public void InorderTraversal()
    {
        Traverse(root);
        Console.WriteLine();
    }

    
    private void Traverse(Node root)
    {
        if (root != null)
        {
            Traverse(root.Left);
            Console.Write(root.Data + " ");
            Traverse(root.Right);
        }
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Inserting nodes into the BST
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(70);
        bst.Insert(60);
        bst.Insert(80);
        
        Console.WriteLine("Traversal of the BST:");
        bst.InorderTraversal();
    }
}
        
        
    
