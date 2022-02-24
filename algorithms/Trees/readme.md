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