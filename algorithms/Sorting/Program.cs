using Sort;


int[] a = { 8, 4, 2, 3, 8, 1 };
int[] b = { 3, 7, 9, 10 };

int[] c = { 2 };

Sorting.Bubble(a, a.Length);
Sorting.Bubble(b, b.Length);


Sorting.InsertSort(a, 5);

Array.ForEach(a, Console.WriteLine);


