/*
Given an array of size n, write a program to check if the given
array is sorted in (ascending / Increasing / Non-decreasing)
order or not. If the array is sorted then return True,
Else return False.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(IsArraySorted(arr));
    }

    public static bool IsArraySorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] >= arr[i - 1])
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
