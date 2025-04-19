/*
Given an array containing both positive and negative integers, we have to
find the length of the longest subarray with the sum of all elements equal
to zero.
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 9, -3, 3, -1, 6, -5 };
        Console.WriteLine(CountSubarraySumToZero(arr));
    }

    public static int CountSubarraySumToZero(int[] nums)
    {
        Dictionary<int, int> sumFrequency = new Dictionary<int, int>();

        int preSum = 0;
        int subarrayCount = 0;
        sumFrequency[0] = 1;

        foreach (int num in nums)
        {
            preSum += num;

            // if we've seen the sum before, it means we found a subarray with zero sum
            if (sumFrequency.ContainsKey(preSum))
            {
                subarrayCount += sumFrequency[preSum];
            }

            if (!sumFrequency.ContainsKey(preSum))
            {
                sumFrequency[preSum] = 0;
            }

            sumFrequency[preSum]++;
        }
        return subarrayCount;
    }
}

// Time complexity O(n)
// Space complexity O(n) -> in the worst case, every prefix sum is unique