
Dictionary<int, int> cache = new();

int factorial(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }

    return factorial(n - 1) * n;

}

int factorialMemo(int n)
{

    if (!cache.ContainsKey(n))
    {
        cache[n] = factorial(n);
    }
    return cache[n];
}


int factorialMemo2(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }

    if (!cache.ContainsKey(n - 1))
    {
        cache[n - 1] = factorialMemo2(n - 1);
    }

    if (!cache.ContainsKey(n))
    {
        cache[n] = cache[n - 1] * n;
    }

    return cache[n];
}


int fibonaci(int n)
{
    if (n == 1 || n == 0) return n;
    return fibonaci(n - 2) + fibonaci(n - 1);
}



int Combination(int n, int r)
{
    int t1, t2, t3;
    t1 = factorialMemo2(5);
    t2 = factorialMemo2(r);
    t3 = factorialMemo2(n - r);
    return (t1) / (t2 * t3);
}


int fibonaciLoop(int n)
{
    int to = 0, t1 = 1, s = 0;
    for (int i = 2; i <= n; i++)
    {
        s = to + t1;
        to = t1;
        t1 = s;
    }

    return s;
}

Console.WriteLine("Fibonachi");
Console.WriteLine(fibonaci(5));
Console.WriteLine(fibonaci(8));


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(factorial(5));
Console.WriteLine(factorialMemo(5));



Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(Combination(5, 2));


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(fibonaciLoop(5));


// transfer one disk
// from    using      to
//  A       B         C
//                   small

//T(1, A, B , C) move disk from A to c using b

// transfer two disk
// from    using      to
//  A       B         C
//                 small
//                  big

// T(2, A, B , C)
// step 1;  TOL(1, A, C , B)
// step 2: move disk from A to c using b
// step 2:  TOL(1, B, A, C)

// transfer two disk
// from    using      to
//  A       B         C
// 
//          small
// bigger    big

//TOH(3, A, B, C)
//  TOH(2, A, C , B);
//  move disk from a to c using b
//  TOH(2, B, A, C)

// Lets look a generic solution
//TOH(n, A, B, C)
//  TOH(n-1, A, C , B);
//  move disk from a to c using b
//  TOH(n-1, B, A, C)

// from    using     to
// a = 1   b=2       c= 3

TOH(3, 1, 2, 3);


void TOH(int n, int a, int b, int c)
{
    if (n > 0)
    {
        TOH(n - 1, a, c, b);
        Console.WriteLine("from " + a + " to " + c);
        TOH(n - 1, b, a, c);
    }
}



int TaylorLoop(int x, int n)
{
    int s = 1;
    for (; n > 0; n--)
    {
        s = 1 + x / n * s;
    }
    return s;
}

Console.WriteLine();
Console.WriteLine("Taylor Series");

Console.WriteLine(Taylor.TaylorRecursion(4.23M, 2));
Console.WriteLine(TaylorLoop(4, 2));
public static class Taylor
{
    static decimal s = 1;
    public static decimal TaylorRecursion(decimal x, decimal n)
    {
        if (n == 0) return s;
        s = 1 + x / n * s;
        return TaylorRecursion(x, n - 1);
    }

}