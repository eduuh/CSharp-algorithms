Node parent = new Node(10);
parent.lchild = new Node(20);
parent.lchild.lchild = new Node(30);




PrintLinkedList(parent);
Recursion(parent);


static Node Recursion(Node recusion)
{
    if (recusion.lchild == null)
    {
        return recusion;
    }

    //20

    //return 30
    var current = Recursion(recusion.lchild);
    current.lchild = recusion;
    return recusion;
}

Console.WriteLine("Recursion");
PrintLinkedList(parent);


static void PrintLinkedList(Node parent)
{
    Node current = parent;

    while (current != null)
    {
        Console.WriteLine(current.data);
        current = current.lchild;
    }
}



public class Node
{
    public int data;
    public Node lchild;

    public Node(int data)
    {
        this.data = data;
    }
}