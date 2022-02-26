BinaryTree tree = new();
// Let us create trees shown in above diagram
tree.root = new Node<int>(1);
tree.root.leftChild = new Node<int>(2);
tree.root.rightChild = new Node<int>(3);
tree.root.leftChild.rightChild = new Node<int>(4);
tree.root.leftChild.leftChild = new Node<int>(5);
tree.root.rightChild.leftChild = new Node<int>(6);
tree.root.rightChild.rightChild = new Node<int>(7);


BinarySearch bst = new();
bst.root = new Node<int>(30);
bst.root.leftChild = new Node<int>(20);
bst.root.rightChild = new Node<int>(40);
bst.root.leftChild.leftChild = new Node<int>(10);
bst.root.leftChild.rightChild = new Node<int>(25);
bst.root.rightChild.leftChild = new Node<int>(35);
bst.root.rightChild.rightChild = new Node<int>(50);

Console.WriteLine("Hash code" + bst.GetHashCode());
Console.WriteLine("Containes 25: " + bst.Contains(25));
Console.WriteLine("Containes 25: " + bst.Search(25).data);
Console.WriteLine("Containes 38: " + bst.Search(38)?.data);
bst.Insert(38);
Console.WriteLine("Containes 38: " + bst.Search(38)?.data);
Console.WriteLine("Containes 40: " + bst.Search(40)?.data);
bst.Insert(80);
Console.WriteLine("Containes 40: " + bst.Search(40)?.data);
Console.WriteLine("Containes 80: " + bst.Search(80)?.data);
Console.WriteLine("Containes 50: " + bst.Search(50)?.data);


BinarySearch bst2 = new();
bst2.Insert(8);
bst2.Insert(10);
bst2.Insert(3);
bst2.Insert(1);
bst2.Insert(6);
bst2.Insert(4);
bst2.Insert(7);
bst2.Insert(13);
bst2.Insert(14);
bst.Insert(10);
Console.WriteLine("inorder");
bst2.InorderTraversal();
Console.WriteLine();
Console.WriteLine(" contains 10: " + bst.Contains(10));

BinarySearch bstr = new();
bstr.RecursiveInsert(8);
bstr.RecursiveInsert(10);
bstr.RecursiveInsert(3);
bstr.RecursiveInsert(1);
bstr.RecursiveInsert(6);
bstr.RecursiveInsert(4);
bstr.RecursiveInsert(7);
bstr.RecursiveInsert(13);
bstr.RecursiveInsert(14);
bstr.RecursiveInsert(10);
Console.WriteLine("inorder");
bstr.InorderTraversal();
Console.WriteLine();
Console.WriteLine(" contains 10: " + bstr.Contains(10));

System.Console.WriteLine("Recursive delete");
bstr.InorderTraversal();
bstr.Delete(bstr.root, 10);
System.Console.WriteLine();
bstr.InorderTraversal();


System.Console.WriteLine("------------------------------");

Console.WriteLine("Tree height  " + tree.Height());
Console.WriteLine("Node Counts  " + tree.Count());
Console.WriteLine("Node Wtih Degree one " + tree.CountDegreeOne());


System.Console.WriteLine("--------------Generating binary tree from Preorder traversal");
int[] pre = new int[] { 30, 20, 10, 15, 25, 40, 50, 45 };
BinarySearch preoder = BinarySearch.CreateFromPre(pre);
preoder.InorderTraversal();

System.Console.WriteLine(" -----------------------------------------------");
System.Console.WriteLine();
System.Console.WriteLine();




Console.WriteLine("Tree traversal");
tree.LeveOrderTraversal();


//tree.CreateBinaryTree();

Console.WriteLine("pre order");
tree.PreOrderTrav();

Console.WriteLine("Post order");
tree.PostOrderTraversal();

Console.WriteLine("Inorder");
tree.InorderTravesalCore();

Console.WriteLine();
tree.IterativePreorderTravesal();
tree.InorderTravesalCore();
