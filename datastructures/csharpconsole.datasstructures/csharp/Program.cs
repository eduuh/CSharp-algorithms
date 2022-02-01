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









