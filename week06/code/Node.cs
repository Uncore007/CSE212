public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        // Check if the value already exists in the tree
        if (value == Data)
        {
            // Value already exists, do nothing
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true; // Value found
        }
        else if (value < Data && Left != null)
        {
            return Left.Contains(value); // Search in the left subtree
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value); // Search in the right subtree
        }
        return false; // Value not found
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // return 0; // Replace this line with the correct return statement(s)

        int leftHeight = 0;
        int rightHeight = 0;

        if (Left != null)
        {
            leftHeight = Left.GetHeight(); // Recursively get the height of the left subtree
        }
        if (Right != null)
        {
            rightHeight = Right.GetHeight(); // Recursively get the height of the right subtree
        }

        // The height of the current node is the maximum height of its subtrees plus one for the current node
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}