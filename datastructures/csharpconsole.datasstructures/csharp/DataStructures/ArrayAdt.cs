namespace csharp;

public class ArrayAdt
{

    public ArrayAdt(int size)
    {
        A = new int[size];
        this.size = size;
    }

    private int[] A;
    private int size;
    private int length;

    public void Display()
    {
        Console.WriteLine("Hello there");
    }

    public int SumArray() {
        int total = 0;
       for (int i = 0; i < A.Length; i++)
       {
           total += A[i];
       }
       return total;
    }
}

internal static class ArrayExtensionMethods {
    public static int SumArray(this int[] arr) {
        int total = 0;
       for (int i = 0; i < arr.Length; i++)
       {
           total += arr[i];
       }
       return total;
    }
}
