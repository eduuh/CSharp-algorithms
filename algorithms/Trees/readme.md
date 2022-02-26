## creating a binary tree

We need a queue datastructure

       

- Create the root node - address 200
- insert the address 200 in the queue.
- take out the address from the queue and let a temporary pointer point to it.

- Ask if the root node has a left child.
- create a new node on temporary variable i  set the value and let the left pointer of p point to i.
- push the new address to of i to the queue.
- Ask if the the node at p has a right  pointer.
- Yes: create the new node using the temporary variable i , set p -> right to point to i
- Push the new address to the queue.

-  take the next address from the queue and let p point to it


             5
      8             6
           9       3
         4    2

   
    
        200 210 212 250 queue:     300

## Drawbacks of binary tree

keys= 40 , 20 , 30, 60,  50, 10 , 70

               40                    0
            20        60             1
               30   50    70         2

Height of this search tree is logarithmic

keys= 10, 20 , 30 , 40 , 50 , 60 , 70

               10
                  20 
                     30 
                         40
                            50
                               60
                                  70

- skewed binary tree.

- The height of the binary tree is 0(n).
- It is use depend on the keys

- We cannot control the order of insertion.
- We need the method to control the height.


## AVL

- Height balanced binary search tree.
- The height is balanced using balanced factor. 
- height of left subtree - height of rigt subtree

     bf = hl - hr - = { -1, 0 , 1}
    if  bf = | hl - hr | <= 1 balanced
    if | bf | = | hl - | imbalanced

