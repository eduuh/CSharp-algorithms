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

    public int SumArray()
    {
        int total = 0;
        for (int i = 0; i < A.Length; i++)
        {
            total += A[i];
        }
        return total;
    }

    public static int[,] twoDArrayExample()
    {
        int[,] arr = new int[4, 2];
        int count = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
                arr[i, j] = count++;

        }
        return arr;
    }

    public static void print2Darray(int[,] arr, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(" " + arr[i, j]);
            }
            Console.WriteLine();
        }
    }

}

internal static class ArrayExtensionMethods
{
    public static int SumArray(this int[] arr)
    {
        int total = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }
        return total;
    }

    public static int SequentialSearch(this int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(this int[] arr, int key)
    {
        /// [o,1,2,3,4,5]
        int low, mid, high;
        low = 0;
        high = arr.Length - 1;

        while (low <= high)
        {
            mid = (low + high) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }
            else if (key > arr[mid])
            {
                low = mid + 1;
            }
            else if (key < arr[mid])
            {
                high = mid - 1;
            }
        }

        return -1;
    }

    public static void RotateRightFunction(this int[] arr, int times)
    {

        int temp, i, j;
        i = 0;
        j = arr.Length - 1;
        for (; i < times; i++, j--)
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    public static void Display(this int[] arr)
    {
        foreach (var val in arr)
        {
            Console.Write(" " + val);
        }
    }

    //intergers
    public static void printInt1(int number)
    {
        char digit = (char)(number % 10 + '0');
        number = number / 10;
        if (number != 0)
        {
            printInt1(number / 10);
        }
        Console.Write("%c" + digit);
    }

    // base 16
    public static void printInt2(int number, int baseValue)
    {
        string conversion = "0123456789ABCDEF";
        char digit = (char)(number % baseValue);
        number = number / baseValue;
        if (number != 0)
        {
            printInt2(number, baseValue);
        }
        Console.Write(" " + conversion[digit]);
    }


}
