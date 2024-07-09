//You like to go fishing and you want to track the quantities of fish you catch.
//Create a new Binary Search Tree.
//Insert you quantities of fish into the tree.
//Then traverse through the tree and print the results to the screen.
//Use the example as a guideline to complete this problem.
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

    // Method to insert a new node user data.
    public void Insert(int data)
    {
        root = InsertR(root, data);
    }

    // Recursive method to insert a new node in BST
    private Node InsertR(Node root, int data)
    {
        
        if (root == null)
        {
            root = new Node(data);
            return root;
        }
        
        if (data < root.Data)
        {
            root.Left = InsertR(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertR(root.Right, data);
        }
        
        return root;
    }
    
    //Method to Traverse the tree.
    public void Traverse()
    {
        TraverseR(root);
        Console.WriteLine();
    }
    
    //Method to traverse the tree recursively
    private void TraverseR(Node root)
    {
        if (root != null)
        {
            TraverseR(root.Left);
            Console.Write(root.Data + " ");
            TraverseR(root.Right);
        }
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Inserting nodes into the BST
        bst.Insert(3);
        bst.Insert(5);
        bst.Insert(7);
        bst.Insert(10);
        bst.Insert(1);
        bst.Insert(9);

        // Printing inorder traversal of the BST
        Console.WriteLine("You caught these amounts of fish.");
        bst.Traverse();
    }
}
