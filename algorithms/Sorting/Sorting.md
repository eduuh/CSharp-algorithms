### Criteria for Analysis

1. Number of comparisons. 
2. Number of swaps.
3. Adaptive
4. Stable.
5. Extra Memory.

### Type of sorting

1. Buble
2. Insertion
3. Selection
4. Heap Sort.
5. Merge sort
6. Quick Sort.
7. Tree sort.
8. Shell Sort.
9. Count Sort.
10. Bucket/Bin Sort
11. Radix Sort.

### Stable

- Very usefull in databases.

Name - > A B C D E F G
makrs    5 8 6 4 6 7 10

----- sorted ---------------

name    D A C E F B G 
marks   4 5 6 6 7 8 10

#### Stable algorithm
- Sort on marks
- Maintain the order of elements. C will come first E

#### Unstable algorithm

- do not presert the order of duplicate elements.


### Types of comparison based sorts and Time complexity

1. Bubble          O(n^2)
2. Insertion      
3. Selection
4. Heap Sort       O(n logn)
5. Merge sort.
6. Quick Sort.
7. Trees sort.
8. Shell sort.     O(n^3/2)


### Types of index based sort . (More space is required)

1. Count sort         O(n)
2. Bucket/Bin sort.
3. Radix sort.


## Bubble Sort

A      8 5 7 3 2
index  0 1 2 3 4

comparisons

- compare first 2 elements
- sort 8

- 8 5 7 3  2     compare 8 5
- 5 8 7 3 2   result and compare 8 7
- 5 7 8 3 2    result compare 8 3
- 5 7 3 8 2    result compare 8 2
- 5 7 3 2 8    result compare 8 2

- 4 comparisons
- 4 swaps

- sort the next big element

- 8 5 7 3 2     compare 8 5
- 5 8 3 7 2   result and compare 8 7
- 8 5 7 3 2     compare 8 5
- 5 8 3 7 2   result and compare 8 7



## Insertiong