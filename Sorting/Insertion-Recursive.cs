/*
Given an array of N integers, write a program to implement
the Recursive Insertion Sort algorithm
*/

public class InsertionSort
{
    public static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        InsertionRecursive(arr, 1, arr.Length - 1);
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
    public static void InsertionRecursive(int[] arr, int i, int n) // i = current index, n = size of array
    {
        if (i == n) return;

        int j = i;
        while (j > 0 && arr[j - 1] > arr[j])
        {
            var temp = arr[j - 1];
            arr[j - 1] = arr[j];
            arr[j] = temp;
            j--;
        }
        InsertionRecursive(arr, i + 1, n);
    }
}