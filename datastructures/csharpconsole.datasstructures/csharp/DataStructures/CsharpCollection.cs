using System.Collections.Generic;

namespace csharp;

public class Collections
{
    public class Arrays
    {
        private int[] _arr;
        public Arrays()
        {
            _arr = new int[10]; //fixed size, 
                                //have to create big arrays hence potential of wasting space
            initialize();
        }
        public void initialize()
        {
            for (int i = 0; i < 10; i++)
            { // 0(n+1)
                _arr[i] = i; /// 0(1)
            }
        }
        public void Display()
        {
            Array.ForEach(_arr, (x) =>
            {
                x = x * 2;
                Console.WriteLine(x);
            });
        }

    }

    public class List
    {
        // implementation of dyanamic arrays
        // dyanamic array grow or shrink as needed
        private List<int> al = new();

        public List()
        {
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.ForEach(Console.Write);
            al.Insert(2, 9);
            Console.WriteLine("The values after insertion");
            al.ForEach(Console.Write);
        }
    }

    public class SortedList
    {
        private SortedList<string, int> slist;
        public SortedList()
        {
            slist = new();
            slist["Mason"] = 55;
            slist["Jacob"] = 77;
            slist["William"] = 80;
            slist["Emma"] = 50;

            Console.WriteLine("Total number of students is " + slist.Count);
            foreach (string key in slist.Keys)
            {
                Console.WriteLine(key + "score marks:" + slist[key]);
            }

            Console.WriteLine("Emma present in class " + slist.ContainsKey("Emma"));
            slist.Remove("Emma");
            Console.WriteLine("Emma present in class " + slist.ContainsKey("Emma"));
        }
    }

    public class LinKedList
    {
        // doubly linked list
        // you can add and remove from both ends of the list
        private LinkedList<int> ll;
        public LinKedList()
        {
            ll = new();
            ll.AddFirst(10); // 0(1)
            ll.AddLast(20);  // 0(1)
            ll.AddFirst(10);
            ll.AddFirst(21);

            Console.Write("Content of linked list: ");
            foreach (int val in ll)
            {
                Console.WriteLine(val + "");
            }

            ll.RemoveFirst();
            ll.RemoveLast();

            Console.Write("Content of linked list: ");
            foreach (int val in ll)
            {
                Console.WriteLine(val + "");
            }

        }

    }

    public class Stack
    {
        private Stack<int> stk;

        public Stack()
        {
            stk = new();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(4);
            stk.Push(5);

            Console.WriteLine("Element at top of stack::" + stk.Peek());
            int size = stk.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Pop from stack: " + stk.Pop());
            }
        }
    }

    public class Queue
    {
        private Queue<int> que = new Queue<int>();
        public Queue()
        {
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(4);
            int size = que.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Dequeue from Queue: " + que.Dequeue());
            }
        }

    }

    public class SortedSetDemo
    {
        private SortedSet<string> ts = new SortedSet<string>();
        public SortedSetDemo()
        {
            ts.Add("India");
            ts.Add("USA");
            ts.Add("Brazile");

            foreach (String str in ts)
                Console.Write(str + " ");
        }
    }

    public class SortedDictionary
    {
        SortedDictionary<string, int> tm = new SortedDictionary<string, int>();
        public SortedDictionary()
        {
            tm["Mason"] = 55;
            tm["Jacod"] = 77;
            tm["William"] = 80;

            foreach (string key in tm.Keys)
            {
                Console.WriteLine();
                Console.WriteLine(key + " score mark " + tm[key]);
            }
        }

    }

    public class HashSet
    {
        HashSet<string> hs = new HashSet<string>();

        public HashSet()
        {
            hs.Add("India");
            hs.Add("Canada");
            hs.Add("UsA");


            foreach (String str in hs)
            {
                Console.Write(str);
            }
        }
    }

    public class Dictionary
    {
        private Dictionary<string, int> hm = new Dictionary<string, int>();
        public Dictionary() { 
          hm["Mason"]  = 55;
          hm["Jacod"] = 77;
          hm["William"] = 99;

           Console.WriteLine("Total numbers of students in class ::" + hm.Count);
          foreach(string key in hm.Keys){
             Console.WriteLine(key + " score marks ::" +hm[key] );
          }
        }
    }
}
