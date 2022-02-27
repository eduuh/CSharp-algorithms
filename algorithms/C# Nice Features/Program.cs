List<int> numbers = null;
int? a = null;

numbers ??= new List<int>();
numbers.Add(4);
numbers.Add(5);

string.Join(" ", numbers);

numbers.ForEach(Console.WriteLine);
Console.WriteLine(num);
