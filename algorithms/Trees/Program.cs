BinaryTree tree = new();
// Let us create trees shown in above diagram
tree.root = new Node<int>(1);
tree.root.leftChild = new Node<int>(2);
tree.root.rightChild = new Node<int>(3);
tree.root.leftChild.rightChild = new Node<int>(4);
tree.root.leftChild.leftChild = new Node<int>(5);
tree.root.rightChild.leftChild = new Node<int>(6);
tree.root.rightChild.rightChild = new Node<int>(7);

Console.WriteLine("Tree height  " + tree.Height());
Console.WriteLine("Node Counts  " + tree.Count());
Console.WriteLine("Node Wtih Degree one " + tree.CountDegreeOne());


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
