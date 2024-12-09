/*
Given an array that contains only 1 and 0 return the count
of maximum consecutive ones in the array.
*/

using System;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 1, 0, 1, 1, 1 };
        Console.WriteLine(MaximumConsecutiveOnes(arr));
    }

    public static int MaximumConsecutiveOnes(int[] arr)
    {
        int max = 0;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                count++;
                if (count > max) max = count;
            }
            else
            {
                count = 0;
            }
        }
        return max;
    }
}
