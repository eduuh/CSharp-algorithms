public class AvlTree
{

    internal Node root { get; set; }
    internal class Node
    {
        internal Node lchild;
        internal Node rchild;
        internal int data;
        internal int height;

        public Node(int data)
        {
            this.data = data;
        }

    }

    internal Node RecursiveInsert(int key)
    {
        Node insertedNode = recursiveInsertCore(root, key);
        if (root is null) root = insertedNode;
        return insertedNode;
    }

    int NodeHeight(Node node)
    {
        int hl, hr;
        hl = node.lchild != null ? node.lchild.height : 0;
        hr = node.rchild != null ? node.rchild.height : 0;
        return hl > hr ? hl + 1 : hr + 1;
    }


    int BalanceFactor(Node node)
    {
        int hl, hr;
        hl = node.lchild != null ? node.lchild.height : 0;
        hr = node.rchild != null ? node.rchild.height : 0;
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
        }
        else
        {

            if (root.data < key)
            {
                root.rchild = recursiveInsertCore(root.rchild, key);
            }
            else if (root.data > key)
            {
                root.lchild = recursiveInsertCore(root.lchild, key);
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

        }

        return root;
    }

    private Node RLRotation(Node root)
    {
        throw new NotImplementedException();
    }

    private Node RRRotation(Node root)
    {
        throw new NotImplementedException();
    }

    private Node LRRotation(Node root)
    {
        Node pl = root.lchild;
        Node plr = root.rchild;

        pl.rchild = plr.lchild;
        pl.lchild = plr.rchild;

        plr.lchild = pl;
        plr.rchild = pl;

        pl.height = NodeHeight(pl);
        plr.height = NodeHeight(root);
        plr.height = NodeHeight(plr);
        if (this.root == root)
        {
            this.root = plr;

        }
        return plr;
    }

    // creating avl tree  10 , 20 , 30 , 25 , 28 , 25 5


}