// element in the left subtree are smaller
// will not have duplicate
// inorder travesal gives the elements inorder.

//          30
//     15         50
//  10    20    40   60

public class BinarySearch
{
    public Node<int> root { get; set; }

    internal bool Contains(int key)
    {
        if (root is null) return false;
        Node<int> current = root;

        while (current is not null)
        {
            if (current.data == key)
            {
                return current.data == key;
            }
            else if (key < current.data)
            {
                current = current.leftChild;
            }
            else
            {
                current = current.rightChild;
            }
        }
        return false;
    }

    internal Node<int> Search(int key)
    {
        if (root is null) return null;
        return recursive(root);
        Node<int> recursive(Node<int> root)
        {
            while (root is not null)
            {
                if (key == root.data)
                {
                    return root;
                }
                else if (key < root.data)
                {
                    return recursive(root.leftChild);
                }
                else
                {
                    return recursive(root.rightChild);
                }
            }
            return root;
        }
    }

    internal void Insert(int key)
    {
        if (root is null)
        {
            root = new Node<int>(key);
            return;
        }
        Node<int> current = root, r = root;

        while (current is not null)
        {
            r = current;
            if (key < current.data)
            {
                current = current.leftChild;
            }
            else if (key > current.data)
            {
                current = current.rightChild;
            }
            else return;
        }
        Node<int> newNode = new Node<int>(key);
        if (key
            < r.data) { r.leftChild = newNode; }
        else
        {
            r.rightChild = newNode;
        }
    }


    internal Node<int> Delete(Node<int> p, int key)
    {
        Node<int> q;
        if (p == null)
        {
            return null;
        }

        if (p.leftChild == null && p.rightChild == null)
        {
            if (p == root)
            {
                root = null;
            }
            return null;
        }


        if (key < p.data)
        {
            p.leftChild = Delete(p.leftChild, key);
        }
        else if (key > p.data)
        {
            p.rightChild = Delete(p.rightChild, key);
        }
        else
        {
            if (Height(p.leftChild) > Height(p.rightChild))
            {
                q = InPre(p.leftChild);
                p.data = q.data;
                p.leftChild = Delete(p.leftChild, q.data);
            }
            else
            {
                q = InSucc(p.rightChild);
                p.data = q.data;
                p.rightChild = Delete(p.rightChild, q.data);
            }
        }
        return p;
    }

    private int Height(Node<int> root)
    {
        int x, y;
        if (root == null) return 0;
        x = Height(root.leftChild);
        y = Height(root.rightChild);
        return x > y ? x + 1 : y + 1;
    }

    private Node<int> InPre(Node<int> node)
    {
        while (node is not null && node.rightChild != null)
        {
            node = node.rightChild;
        }
        return node!;
    }


    private Node<int> InSucc(Node<int> node)
    {
        while (node is not null && node.leftChild != null)
        {
            node = node.leftChild;
        }
        return node!;
    }


    internal Node<int> RecursiveInsert(int key)
    {
        if (this.root == null)
        {
            this.root = new Node<int>(key);
        }

        return recursiveInsertCore(root, key);
    }

    internal void InorderTraversal()
    {

        recursive(root);
        void recursive(Node<int> root)
        {
            if (root is null) return;
            recursive(root.leftChild);
            Console.Write(root.data + " ");
            recursive(root.rightChild);
        }
    }

    private Node<int> recursiveInsertCore(Node<int> root, int key)
    {
        if (root is null)
        {
            Node<int> newnode = new(key);
            root = newnode;
            return root;
        }
        if (root.data < key)
        {
            root.rightChild = recursiveInsertCore(root.rightChild, key);
        }
        else if (root.data > key)
        {
            root.leftChild = recursiveInsertCore(root.leftChild, key);
        }
        return root;
    }


    // generating binary search tree from traversal
    // preoder + inorder
    // preoder + inorder

    // preoder 30 20 10 15 25 40 50 45
    // don/t woryy thhe inorder of binary tree is the sorted order.
    //inorder: 10 15 20 25 3o 40 45 50

    public static BinarySearch CreateFromPre(int[] pre)
    {
        Stack<Node<int>> stack = new Stack<Node<int>>();
        BinarySearch result = new();
        Node<int> p;
        int i = 0;

        result.root = new Node<int>(pre[i++]);
        p = result.root;

        while (i < pre.Length)
        {
            if (pre[i] < p.data)
            {
                p.leftChild = new(pre[i++]);
                stack.Push(p);
                p = p.leftChild;
            }
            else
            {
                bool succees = stack.TryPeek(out Node<int> q);
                var value = succees ? q.data : Int16.MaxValue;
                if (pre[i] > p.data && pre[i] < value)
                {
                    p.rightChild = new Node<int>(pre[i++]);
                    p = p.rightChild;
                }
                else
                {
                    p = stack.Pop();
                }
            }
        }



        return result;
    }


}