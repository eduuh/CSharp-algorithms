using csharp;
//var person = new Person("Edwin", "Kamau", 24);
//var dump = ObjectDumper.Dump(person);
//Console.WriteLine(ObjectDumper.Dump(dump));

//Sum Array
int[] array= new int[5] {1, 2,3,4,5};
//WriteLine($"{array.SumArray()}");

int[,] arr = ArrayAdt.twoDArrayExample();

ArrayAdt.print2Darray(arr, 4, 2);

int index = array.SequentialSearch(3);
int bindex = array.BinarySearch(3);
int bindex2 = array.BinarySearch(5);
int bindex3 = array.BinarySearch(6);

WriteLine($"index of 3 is: {index}");
WriteLine($"index of 3 is: {bindex}");
WriteLine($"index of 5 is: {bindex2}");
WriteLine($"index of 5 is: {bindex3}");

array.RotateRightFunction(2);
array.Display();

//print base 10 interger
ArrayExtensionMethods.printInt1(25);
System.Console.WriteLine();
ArrayExtensionMethods.printInt2(25, 16);

//arrays
//index based
//memory is Sequential and fixed
//potential of large allocation to solve the unkwon size in future

Arrays arrays = new Collections.Arrays();
arrays.Display();

// Dynamic Arrays
// List<T> implementaiton
// grow and shrink as needed

List dynamicarray = new Collections.List();


// Sorted List
// data structure that maps keys to values
// implements IDictionary<T> and is impremented as a 
// sorted array so the key-values are stored in sorted
// does not array duplicates keys but values could be duplicated
// Key based searching is doin using binary search
SortedList sortedList = new Collections.SortedList();


//Linked Lisit are dynamic data structures
//Memory is allocated at runtime
//linked list does not store data contigously
//use links that point to the next element
//
//Performance wise: linked list are slower than arrays
// no direct access to linked list element
// The linked list is a useful data stcuteru if the number of element is not know ahead of time
//
// Flavors
//  linear
//  circular
//  doubly
//  doubly circular
//
//  binary search does not work on Linked list

var ll = new LinKedList();


// stack is implemented by stack<T> it implemets ICollection interface
// Element are added on to the stack by calling push () fuciton and element are removed form the stack by calling pop() fuction.

Stack stack = new Stack();

// A queue is first in first out kind of data structures
// The element is added to the queue first will be the first to be removed from the queu
//
// Queu hast the following application
// Access to shared resources (printer)
// Multiprogramming
// Message queues

Queue queue  = new ();

// Binary search Tree
// A binary search tree (BST) is a binary tree
// the key in the left subtree is less than the key in its parent node
// The key in the right subtree is greater or equal the key in its parent node.

// Time complexity is O(log n) in case of a balanced tree
// Right skewed trees = > o(n)
// left skewed trees = > o(n)
//
// balanced search tree
// Red black tree(RB-Tree)
// Avl tree
//
// Sorted set<T> implements the ISet<> interface
// Stores only unique elements.
// SotetedSet<T> is implemented using a red-black balanced binary search tree
// elements are stored in sequential order
// Count , Add(T) , Clear(T), Contains(T) , Removed(T)


SortedSetDemo sortedSet = new();

// SortedDictionary is an interface that maps to values
// A SortedDictionary<> is an implementation of IDictionary<>
// implemented using red-black balanced binary trees
// The keys are stored in a sorted order
// prorperties and methods: Count , Item[Key], Add(key, value)
// Clear(),  ContainsKey(), Remove(key)

SortedDictionary sortedDictionary = new();

//Priority Queu (Heap)
//Priority queue is implemented using a binary heap data structures. In a heap, the record are stored in an array so that each key is larger thahn its two childrend keys.
//
//Each nod int heap follow the same rule that the parent value is greater than its two children are;

// 
// there are two types of heap data structures
// 1. Max heap: each node should be greater than or equal to each of its children
// 2. Min heap: each node should be smaller than or equal to each fo its childrens
//
//
//
// A heap is useful data structure, when you want to get min/ max by one from data. Heap -sort Uses max heap to sert data in increasing/decreasing order.
//
// PriorityHeaap is missing from c#
//
//
//
//
//
//


// Hash-Table: csharp implementation HashSet
// A hash-Table is a datastructure that maps keys to values
// Each position of the Hash-Table is called a slot.
// The hash table uses a hash function to calculated an index of array of slots
// the process of string object using a hash function
// 1. Create an array of size M to store object , the array i called Hast-Table
// 2. Find a hash code of an object by passing it through the hast fuction.
// 3. Take module of hash code by the size of hash-table to get the index of the table where object will be stored.
// 4. Finaly soter the object in the designated index.
//

// process of searching objects in hash table using a hash funciton
//
// 1. Find a hash code of the object we are searching for by passing it through the hash function.
// 2  Take module fo hash code by the size of hash-table to get the index of the table where objects are stored.
// 3. finally, retrive the object from the designated index.


// Hash-table Abstract Data Type (AdT)
// The hash table is a useful data structure for implementing dictionary. The average time to search for an element in a Hast-Table is 0(1)
//
//HashSet<> is a class which implements ISet<> interface
//HashSet<> is implemented using a hash table
//HashSet<> is implemented using a hast table its elements are not stored in sequential order.
//

HashSet hashset = new HashSet();


// dictionary<> is a data structure that maps keys to values
// A Disctionary<> is an implementation fo IDictionary<> interface
// implemented using hash table so the key values pairs are not stored in sorted order.
//
// Dictionary does not allow duplicated keys buts values can be duplicated
//

Dictionary dict = new Dictionary();
