/*
Problem Statement: Given an array of integers and an integer k,
return the total number of subarrays whose sum equals k.
-------------------
Approach: Prefix Sum + Hash Frequency Technique
- Track running prefix sum while iterating through array
- Use hash map to store frequency of prefix sums
- For each index, check if (current prefix sum - K) exists in previous sums
- If it exists, means a subarray with sum K is found
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main()
    {
        int[] arr = { 3, 1, 2, 4 };
        int k = 6;
        Console.WriteLine(CountSubArrays(arr, k)); 
    }
    
    public static int CountSubArrays(int[] arr, int k)
    {
        Dictionary<int, int> sumFrequency = new Dictionary<int, int>();
        // Initialize with 0 sum having frequency 1 
        // (represents empty subarray before start)
        sumFrequency[0] = 1;
        
        int preSum = 0;
        int count = 0;
        
        foreach (int num in arr)
        {
            // Calculate running prefix sum
            preSum += num;
            
            // Check if there's a subarray sum that equals K
            if (sumFrequency.ContainsKey(preSum - k))
            {
                count += sumFrequency[preSum - k];
            }
            
            // Update frequency of current prefix sum
            if (!sumFrequency.ContainsKey(preSum))
            {
                sumFrequency[preSum] = 0;
            }
            sumFrequency[preSum]++;
        }
        
        return count;
    }
}

// Time complexity O(n) 
// Space complexity O(n) 