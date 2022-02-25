using System.Collections.Generic;

public class BinaryTree
{
    public Node<int> root;



    public void PreOrderTrav()
    {
        PreOrderTravCore(root);
    }

    public void PostOrderTraversal()
    {
        PostOrderTravesalCore(root);
    }

    public void InorderTravesalCore()
    {
        InorderTravesalCore(root);
    }
    private void PreOrderTravCore(Node<int> root)
    {
        if (root == null)
        {
            return;
        }

        Console.Write(root.data + " ");
        PreOrderTravCore(root.leftChild);
        PreOrderTravCore(root.rightChild);
    }
    private void InorderTravesalCore(Node<int> root)
    {
        if (root == null)
        {
            return;
        }

        InorderTravesalCore(root.leftChild);
        Console.Write(root.data + " ");
        InorderTravesalCore(root.rightChild);
    }
    private void PostOrderTravesalCore(Node<int> root)
    {
        if (root == null)
        {
            return;
        }

        InorderTravesalCore(root.leftChild);
        InorderTravesalCore(root.rightChild);
        Console.Write(root.data + " ");
    }


    public void IterativePostorderTravesal()
    {
        Stack<Node<int>> stack = new();
        Node<int> current = root;
        Node<int> prev = null;

        while (stack.Count != 0)
        {
            if (prev == null || prev.leftChild == current || prev.rightChild == current)
            {
                Console.Write(current.data + " ");
                stack.Push(current);
                current = current.leftChild;
            }
            else
            {
                current = stack.Pop();

            }
        }
    }
    public void IterativePreorderTravesal()
    {
        Stack<Node<int>> stack = new();
        Node<int> current = root;

        while (current != null || stack.Count > 0)
        {
            if (current is not null)
            {
                Console.Write(current.data + " ");
                stack.Push(current);
                current = current.leftChild;
            }
            else
            {
                current = stack.Pop();
                current = current.rightChild;
            }
        }
    }



    public void IterativeInorderTravesal()
    {
        Stack<Node<int>> stack = new();
        Node<int> current = root;

        while (current != null || stack.Count > 0)
        {
            if (current is not null)
            {

                stack.Push(current);
                current = current.leftChild;
            }
            else
            {
                current = stack.Pop();
                Console.Write(current.data + " ");
                current = current.rightChild;
            }
        }

    }



    public void PostOrderInorderTravesal()
    {
        Stack<Node<int>> stack = new();
        Node<int> current = root;

        while (current != null || stack.Count > 0)
        {
            if (current is not null)
            {

                stack.Push(current);
                current = current.leftChild;
            }
            else
            {
                current = stack.Pop();
                Console.Write(current.data + " ");
                current = current.rightChild;
            }
        }
    }

    /// <summary>
    ///        8
    ///   3          9
    /// 7          6    4
    // 5             2

    // out  8 3 9
    //adres8 que:  addres3 addres9
    /// </summary>

    /// <summary>
    ///  Can we generate tree from traversals
    /// </summary>
    /// <returns></returns>

    //preorder:  A B C
    //postorder: c b a

    // with the same preoder we can generate 5 order
    // you cannot generate a unique tree from on order
    // with two  preoder, postorder -> you cannot generate one tree 1+

    // to generate a tree
    // preoder + inorde
    // postoder + inorder

    //generate a tree from preoder => 4, 7 , 9 , 6, 3 , 2 , 5 , 6, 1
    // inorder => 7, 6, 9 , 3 , 4 , 5 , 8 , 2 , 1 

    // take the inorder result in that order
    // if preoder, the first element is the node,
    // search the first element from the inorder list
    // create the first node split the list
    // the first split list will be the first leave
    // the second split is the second list

    // go to the second elemen in preoder list

    public BinaryTree CreateBinaryTree(string preoder, string inorder)
    {
        BinaryTree binarytree = new BinaryTree();

        Node<int> p;
        foreach (char value in preoder)
        {
            p = new Node<int>(value);
            var splits = inorder.Split(value);
        }



        return binarytree;
    }

    public int Height()
    {
        return heightCore(root);
    }
    private int heightCore(Node<int> root)
    {
        int x = 0, y = 0;
        if (root is null)
        {
            return 0;
        }

        x = heightCore(root.leftChild);
        y = heightCore(root.rightChild);

        if (x > y) return x + 1;
        else return y + 1;
    }

    private int Count2(Node<int> root)
    {
        if (root is null) return 0;
        if (root.leftChild is not null && root.rightChild)
            return Count2(root.leftChild) + Count2(root.rightChild) + 1;
        return Count2(root.leftChild) + Count2(root.rightChild);
    }


    public int CountLeafNode()
    {
        return CountLeafNodeCore(root);
    }
    private int CountLeafNodeCore(Node<int> root)
    {
        int x, y;
        if (root is not null)
        {
            x = CountLeafNodeCore(root.leftChild);
            y = CountLeafNodeCore(root.rightChild);
            if (root.rightChild is null && root.leftChild is null)
            {
                return x + y + 1;
            }
            else
            {
                return x + y;
            }
        }
        return 0;
    }

    public List<int> LeveOrderTraversal()
    {
        Queue<Node<int>> queue = new();
        List<int> result = new();

        if (root is null) return result;


        queue.Enqueue(root);

        Node<int> p;

        while (queue.Count > 0)
        {
            bool success = queue.TryDequeue(out p);
            if (success && p is not null)
            {
                result.Add(p.data);
                Console.WriteLine(p.data);
                if (p.leftChild != null)
                {
                    result.Add(p.leftChild.data);
                    queue.Enqueue(p.leftChild);
                }

                if (p.rightChild != null)
                {
                    result.Add(p.rightChild.data);
                    queue.Enqueue(p.rightChild);
                }
            }

        }
        return result;
    }

    /*
        public int NumberOfFullNodes()
        {
            return CountFullNodesCore(root);
        }

        */

    public int SumofAllElement()
    {

        return recursiveSum(root);


        int recursiveSum(Node<int> root)
        {
            int x, y;
            if (root is not null)
            {
                x = recursiveSum(root.rightChild);
                y = recursiveSum(root.rightChild);
                return x + y + root.data;
            }
            return 0;
        }
    }

    //nodes with degree 2
    private int CountLeaves(Node<int> root)
    {
        int x, y;
        if (root is not null)
        {
            x = CountLeaves(root.leftChild);
            y = CountLeaves(root.rightChild);

            if (root.leftChild is not null && root.rightChild is not null)
            {
                return x + y + 1;
            }
            else
            {
                return x + y;
            }

        }
        return 0;
    }

    //internal node
    private int CountwithDegreeoneandTwo(Node<int> root)
    {
        int x, y;
        if (root is not null)
        {
            x = CountLeaves(root.leftChild);
            y = CountLeaves(root.rightChild);

            if (root.leftChild is not null || root.rightChild is not null)
            {
                return x + y + 1;
            }
            else
            {
                return x + y;
            }

        }
        return 0;
    }

    //conditions leaf node
    //if(root.leftchild  != p.rightchild)

    // Node degree 2
    // if(p.leftchild && p.rightchild)

    //degree 1 or 2
    // if(p.leftchild || p.rightchild)

    // deg 1
    // if (p.leftChild != null && p.rightchild == null) || (p.rightchild != null && p.Leftchild ==null)
    // this is a very length conditions
    // we can write it with exclusive or operator
    // if(p.LeftChild !=null ^ p.rightChild !=null)

    public int CountDegreeOne()
    {
        return CountDegreeOneCore(root);
    }
    private int CountDegreeOneCore(Node<int> root)
    {
        int x, y;
        if (root is not null)
        {
            x = CountDegreeOneCore(root.leftChild);
            y = CountDegreeOneCore(root.rightChild);

            if (root.leftChild != null ^ root.rightChild != null)
            {
                return x + y + 1;
            }
            else
            {
                return x + y;
            }
        }
        return 0;
    }
    public int Count()
    {
        return CountNodes(root);
    }
    private int CountNodes(Node<int> root)
    {
        int x = 0, y = 0;
        if (root is not null)
        {
            x = CountNodes(root.leftChild);
            y = CountNodes(root.rightChild);
            return x + y + 1;
        }
        return 0;
    }
    public void CreateBinaryTree()
    {
        Queue<Node<int>> queue = new();
        Node<int> p, i;
        Console.WriteLine("Enter the root value");
        int.TryParse(Console.ReadLine(), out int value);
        root = new Node<int>(value);
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            p = queue.Dequeue();
            Console.WriteLine("Enter the right node for " + p.data);
            int.TryParse(Console.ReadLine(), out int right);

            if (right != 0) p.rightChild = new Node<int>(right);
            if (p.rightChild != null) queue.Enqueue(p.rightChild);
            Console.WriteLine("Enter the left node for " + p.data);
            int.TryParse(Console.ReadLine(), out int left);
            if (right != 0) p.leftChild = new Node<int>(left);
            if (p.leftChild != null) queue.Enqueue(p.leftChild);

        }

    }

}