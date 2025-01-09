/*
Given an integer array arr, find the contiguous subarray
(containing at least one number) which has the largest sum
and returns its sum and prints the subarray.
*/

// return sum only

using System;
public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MaxSubArraySum(arr));
    }

    public static int? MaxSubArraySum(int[] arr)
    {
        int sum = 0;
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum > max)
            {
                max = sum;
            }
            if (sum < 0)
            {
                sum = 0;
            }
        }
        if (max < 0)
        {
            return null;
        }
        return max;
    }
}

// return sum and sub array variation
public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        var result = MaxSubArraySum(arr);
        if (result.maxSum.HasValue)
        {
            Console.WriteLine($"Maximum Sum: {result.maxSum}");
            Console.WriteLine("Subarray elements: " + string.Join(" ", result.subArray));
        }
        else
        {
            Console.WriteLine("No positive subarray found");
        }
    }

    public static (int? maxSum, int[] subArray) MaxSubArraySum(int[] arr)
    {
        int sum = 0;
        int max = int.MinValue;
        int start = 0;
        int end = 0;
        int tempStart = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum > max)
            {
                max = sum;
                start = tempStart;
                end = i;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = i + 1;
            }
        }
        if (sum < 0)
        {
            return (null, new int[0]);
        }
        int[] subArray = new int[end - start + 1];
        System.Array.Copy(arr, start, subArray, 0, end - start + 1);

        return (max, subArray);
    }
}
