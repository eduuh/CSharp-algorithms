using dsaalgo;


string prefix = "a+b*c-d/e";

string prefix2 = "1+2-6";
Console.WriteLine(Postfix.PostfixEvaluation(prefix2));

Console.WriteLine(Extensions.ToPostfix(prefix));

int[ , ] arry = new int[,] { {4,4,4}};

int row = arry.GetLength(0);
int column = arry.GetLength(1);

HashSet<int> coltobezero = new HashSet<int>();
HashSet<int> rowtobezero = new HashSet<int>();

coltobezero.Add(2);
rowtobezero.Add(2);



int rows = arry.GetLength(0);
int cols = arry.GetLength(1);

List<Element> sm = new List<Element>();
sm.Add(new Element() { row  = row, column = column, element = 0});


var  tem = "10";
int one = tem[0];

Console.WriteLine(one - '0');

"edwin".ToCharArray();




public struct Element {
   public int row;
   public int column;
   public int element;
}

