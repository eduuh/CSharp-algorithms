using csharp;

var person = new Person("Edwin", "Kamau", 24);
var dump = ObjectDumper.Dump(person);
Console.WriteLine(dump);

structStuff();

Console.WriteLine();

void structStuff()
{
    var array = new ArrayAdt();
    array.Display();
    Console.WriteLine();
}
