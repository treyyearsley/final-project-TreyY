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

    
    private Node InsertR(Node root, int data)
    {
        //Create a method to insert into the tree recursively.
        
    }
    
    //Method to Traverse the tree.
    public void Traverse()
    {
        TraverseR(root);
        Console.WriteLine();
    }
    
    
    private void TraverseR(Node root)
    {
        //create a method to traverse the tree recursively.
    }
}

public class Program
{
    public static void Main()
    {
        
    }
}
