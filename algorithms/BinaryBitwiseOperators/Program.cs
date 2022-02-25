// bitwise operators

byte a1 = 255;

// And  & (both)
// Or   || (Either)
// Xor   ^ (exclusive or, different)
// Not   ~ (Invert)

int a = 25;
int b = 5;

var result = a & b;

int c = 75;

Console.WriteLine("Result: " + Convert.ToString(c, 2).PadLeft(8, '0'));


Console.WriteLine("And Operations");
Console.WriteLine("Result: " + Convert.ToString(a, 2).PadLeft(8, '0'));
Console.WriteLine("Result: " + Convert.ToString(b, 2).PadLeft(8, '0'));
Console.WriteLine("---------------------");
Console.WriteLine("Result: " + Convert.ToString(result, 2).PadLeft(8, '0'));

Console.WriteLine("");

Console.WriteLine("Or Operations");
Console.WriteLine("Result: " + Convert.ToString(a, 2).PadLeft(8, '0'));
Console.WriteLine("Result: " + Convert.ToString(b, 2).PadLeft(8, '0'));
Console.WriteLine("---------------------");
Console.WriteLine("Result: " + Convert.ToString(a | b, 2).PadLeft(8, '0'));


Console.WriteLine("");

Console.WriteLine("XOr Operations");
Console.WriteLine("Result: " + Convert.ToString(a, 2).PadLeft(8, '0'));
Console.WriteLine("Result: " + Convert.ToString(b, 2).PadLeft(8, '0'));
Console.WriteLine("---------------------");
Console.WriteLine("Result: " + Convert.ToString(a ^ b, 2).PadLeft(8, '0'));



Console.WriteLine("");
var invertresult = (byte)~a;
Console.WriteLine("INvert a Value Operations");
Console.WriteLine("a:     " + Convert.ToString(a, 2).PadLeft(32, '0'));
Console.WriteLine("invert:" + Convert.ToString(invertresult, 2).PadLeft(32, '0'));

// Bitwise shifting
// left <<
// right >>

//usage
int c2 = 25;

Console.WriteLine("");
Console.WriteLine("INvert a Value Operations");
Console.WriteLine("d:            " + Convert.ToString(c2, 2).PadLeft(32, '0'));
Console.WriteLine("shifted value:" + Convert.ToString(c2 << 7, 2).PadLeft(32, '0'));

// Toggling boolean
// Enum flags
// masking


//invert booleans
var d = true;
d ^= true; // d becomes false

Console.WriteLine();

Console.WriteLine("Enums Flags");
var somcolors = (byte)Colors.Red | (byte)Colors.White;
Console.WriteLine($"{Convert.ToString((byte)somcolors, 2).PadLeft(8, '0')}");

if ((somcolors & (byte)Colors.Red) == (byte)Colors.Red)
{
    Console.WriteLine("Blue is active");
}

if ((somcolors & (byte)Colors.White) == (byte)Colors.White)
{
    Console.WriteLine("White is active");
}

//masking
// When you mask a value , is when you want to extract a piece of information
// 0011100  input
// 0000100  < important bit (the mask)
// 0000100   get rid of every expect what is in the mask.

Console.WriteLine();
Console.WriteLine("   ");
var input = (byte)Colors.White | (byte)Colors.Red;
var mask = (byte)Colors.White;

var resultmask = input & mask;

Console.WriteLine((Colors)resultmask);

enum Colors
{
    Red = 2,
    White = 4,

    Yellow = 8,

    Pink = 16

}


