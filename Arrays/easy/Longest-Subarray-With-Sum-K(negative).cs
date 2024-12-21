
/*
Given an array and a sum k, we need to print the length of
the longest subarray that sums to k.
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { -1, 1, 1 };
        int k = 1;
        var result = LongestSubarrayWithSumK(arr, k);
        Console.WriteLine(result);
    }

    public static int LongestSubarrayWithSumK(int[] arr, int k)
    {
        // prefix dictionary that stores each index and its sum (i + all the previous elements)
        Dictionary<int, int> prefixSumMap = new Dictionary<int, int>();
        int prefixSum = 0;
        int maxLength = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            // update the sum
            prefixSum += arr[i];

            // Check if the entire array up to the current index has sum k
            if (prefixSum == k)
            {
                maxLength = i + 1;
            }

            // Check if (prefixSum - k) exists in the map
            // Subtracting K allows us to "look back" into the array to see if
            // a previous prefix sum can form a subarray with the current sum.
            if (prefixSumMap.ContainsKey(prefixSum - k))
            {
                int length = i - prefixSumMap[prefixSum - k];
                maxLength = Math.Max(maxLength, length);
            }

            // If the prefix sum is not already in the map, add it
            if (!prefixSumMap.ContainsKey(prefixSum))
            {
                prefixSumMap[prefixSum] = i;
            }

        }
        return maxLength;
    }
}

// Time complexity O(n) and space complexity O(n)