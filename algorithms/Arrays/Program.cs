using Arrays;

int[] ages = new int[] {2, 3 , 5 , 5, 8};

Console.WriteLine(extensions.LinearSearch(ages, 5));
Console.WriteLine(extensions.LinearSearch(ages, 9));

//chsarp algorithm
int item = Array.Find(ages, element => element == 3);
Console.WriteLine(item);
int[] items = Array.FindAll(ages, element => element >=5);
Array.ForEach(items, Console.WriteLine);


//What if the data was sorted? This a divide and conquer algorithm
//A divide and conquer algorithm is an algoritm that halve the input every interation.
// 1 , 2 , 3 , 4 , 5 , 6
// Binary Search: sorted assumption, O(log(n))

int[] numbers = new int[] { 1, 2, 3 , 4 , 5 , 6};
Console.WriteLine(extensions.BinarySearch(ages, 5));
Array.BinarySearch(numbers, 4);

int[] evennumbers = extensions.findEvenNode(ages, numbers);
Array.ForEach(evennumbers, Console.WriteLine);


Console.WriteLine("Reversed: Reversed:");
int[] reversed = extensions.Reverse(numbers);
Array.ForEach(reversed, Console.WriteLine);


Console.WriteLine("Reversed: inplace:");
int[] reversedinplace = extensions.ReverseInPlace(numbers);
Array.ForEach(reversedinplace, Console.WriteLine);

