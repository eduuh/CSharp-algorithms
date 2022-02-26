public class AvlTree
{

    internal Node root { get; set; }
    internal class Node
    {
        internal Node lchild;
        internal Node rchild;
        internal int data;
        internal int height;

    }

    internal Node RecursiveInsert(int key)
    {
        if (this.root == null)
        {
            this.root = new Node(key);
        }
        return recursiveInsertCore(root, key);
    }

    int NodeHeight(Node node)
    {
        int hl, hr;
        hl = node.lchild != null ? root.lchild.height : 0;
        hr = node.rchild != null ? root.rchild.height : 0;
        return hl > hr ? hl + 1 : hr + 1;
    }


    int BalanceFactor(Node p)
    {
        int hl, hr;
        hl = node.lchild != null ? root.lchild.height : 0;
        hr = node.rchild != null ? root.rchild.height : 0;
        return hl - hr;
    }


    private Node LLRotation(Node p)
    {
        Node pl = p.lchild;
        Node plr = pl.rchild;

        pl.rchild = p;
        p.lchild = plr;
        p.height = NodeHeight(p);
        pl.height = NodeHeight(pl);

        if (root == p)
        {
            root = pl;
        }
        return pl;
    }

    private Node recursiveInsertCore(Node root, int key)
    {
        if (root is null)
        {
            Node newnode = new(key);
            root = newnode;
            newnode.height = 1;
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

        root.height = NodeHeight(root);

        if (BalanceFactor(root) == 2 && BalanceFactor(root.lchild) == 1)
        {
            return LLRotation(root);
        }
        else if (BalanceFactor(root) == 2 && BalanceFactor(root.lchild) == -1)
        {
            return LRRotation(root);
        }
        else if (BalanceFactor(root) == -2 && BalanceFactor(root.lchild) == -1)
        {
            return RRRotation(root);
        }
        else if (BalanceFactor(root) == -2 && BalanceFactor(root.lchild) == 1)
        {
            return RLRotation(root);
        }


        return root;
    }
}