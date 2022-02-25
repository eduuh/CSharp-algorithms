// Let us create trees shown in above diagram





//tree.CreateBinaryTree();




//        2 
//  10         11
//12   13
//pre order output : 2 10 12 13 11      root , traves the left subtree, travese right subtree 
//inorder order travesal: 12 10 13 2 11
// post order travesal:  12 13 10  11 2
public class Node<T>
{
    public T data { get; set; }

    public Node(T data)
    {
        this.data = data;
    }


    public Node<T> leftChild { get; set; }
    public Node<T> rightChild { get; set; }
}
