/*
Given an array, and an element num the task is to find if num
is present in the given array or not. If present print the index
of the element or print -1.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 0, 2, 3, 0, 4, 0, 1 };
        Console.WriteLine(LinearSearch(arr, 3));
    }

    public static bool LinearSearch(int[] arr, int n)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == n) return true;
        }
        return false;
    }
}
