/*
Given an integer array sorted in non-decreasing order, remove the
duplicates in place such that each unique element appears only once.
The relative order of the elements should be kept the same.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4 };
        Console.WriteLine(RemoveDuplicates(arr, arr.Length));
    }

    public static int RemoveDuplicates(int[] arr, int n)
    {
        int i = 0;
        for (int j = 1; j < n; j++)
        {
            if (arr[j] != arr[i])
            {
                i++;
                arr[i] = arr[j];
            }
        }
        return i + 1;
    }
}
