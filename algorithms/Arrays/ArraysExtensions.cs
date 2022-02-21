namespace Arrays;
using System.Collections;

public static class extensions {

    //sequencial search
    public static int? LinearSearch(int[] arr, int n){
         foreach(int current in arr) {
              if(current == n) return n;
         }
         return null;
    }

    public static Boolean BinarySearch(int[] arr, int n){
        int min = 0;
        int max = arr.Length - 1;

        while(min >= max) {
           int mid = (min + max )/ 2;
           if(n == arr[mid]) return true;
           else if(n < arr[mid]){
               mid = mid - 1;
           }else {
               mid = mid + 1;
           }
        }

        return false;
    }

    // aggregation of arrays
    public static int[] findEvenNode(int[] arr1, int[] arr2){
       ArrayList result = new ArrayList();

       foreach(int num in arr1) {
            if(num % 2 == 0) {
                result.Add(num);
            }
       }

       foreach(int num in arr2) {
            if(num % 2 == 0) {
                result.Add(num);
            }
       }

       return (int[])result.ToArray(typeof(int));
    }

    public static int[] Reverse(int[] input){
        int[] reversed = new int[input.Length];
        for(int i = 0; i < reversed.Length; i++) {
           reversed[i] = input[input.Length -i - 1];
        }
        return reversed;
    }

    public static int[] ReverseInPlace(int[] input) {
         for(int i = 0; i < input.Length; i++) {
             int temp = input[i];
             input[i] = input[input.Length - i - 1];
             input[input.Length - i - 1] = temp;
         }
         return input;
    }

}

