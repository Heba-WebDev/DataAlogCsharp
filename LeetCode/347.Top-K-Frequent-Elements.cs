/*
Given an integer array nums and an integer k, return the k most frequent elements.
You may return the answer in any order.
*/

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!dictionary.ContainsKey(num))
            {
                dictionary[num] = 1;
            }
            else
            {
                dictionary[num]++;
            }
        }

        return dictionary
        .OrderByDescending(pair => pair.Value)
        .Take(k)
        .Select(pair => pair.Key)
        .ToArray();
    }
}

// Time Complexity: O(n + m log m) * m size of dictionary *
// Space Complexity: O(m) --> worst case stores up to m entries