/*
Given an array of integers, rotating array of elements by k elements
either left or right.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 7, 8, 9, 10, 11 };
        int k = 3;
        LeftRotateByDPlaces(arr, arr.Length, k);
        Console.WriteLine(string.Join(", ", arr)); // 9, 10, 11, 3, 7, 8
    }

    public static int[] LeftRotateByDPlaces(int[] arr, int n, int k)
    {
        k = k % n;
        int[] temp = new int[k];
        // copy the elements that you want to shift in temp arr
        for (int i = 0; i < k; i++)
        {
            temp[i] = arr[i];
        }
        // now we shift the others k positions to the right
        for (int i = k; i < n; i++)
        {
            arr[i - k] = arr[i];
        }
        // now populate the swapped positions after k positions with temp arr
        for (int i = n - k; i < n; i++)
        {
            arr[i] = temp[i - (n - k)];
        }
        return arr;
    }
}
