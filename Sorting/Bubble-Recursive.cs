/*
Given an array of N integers, write a program to implement
the Recursive Bubble Sort algorithm
*/

public class BubbleSort
{
    public static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleRecursive(arr, arr.Length - 1);
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
    public static void BubbleRecursive(int[] arr, int n)
    {
        if (n == 1) return;

        for (int j = 0; j < n - 2; j++)
        {
            var temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
        BubbleRecursive(arr, n - 1);
    }
}
