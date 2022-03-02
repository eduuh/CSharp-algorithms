namespace Sort;

public static class Sorting
{


    //bubble is adaptive
    //buble is 

    //in every pass you can get useful data.
    //the first pass will givhe  the largest element.
    // the second pass will give the second elements.
    public static void Bubble(int[] a, int n)
    {
        int i, j, flag = 0;
        for (i = 0; i < n - 1; i++)
        {
            flag = 0;
            for (j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    Swap(j, j + 1, a);
                    flag = 1;
                }
            }
            if (flag == 0) break;
        }
    }

    private static void Swap(int i, int j, int[] array)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    // inserting in a sorted array at a sorted position

    //2, 0
    public static void InsertSort(int[] a, int key)
    {
        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] > key)
            {
                a[i] = a[i - 1];
            }
            else if (a[i] < key)
            {
                a[i + 1] = key;
                break;
            }
        }
    }

    public static void InsertionSort(int[] a, int key)
    {

    }

}