/*
Leetcode 349 [Arrays Hashing]
*/

/* First solution with a dictionary */

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var dictionary1 = new Dictionary<int, int>();
        var dictionary2 = new Dictionary<int, int>();
        var result = new List<int>();


        foreach (int num in nums1)
        {
            if (!dictionary1.ContainsKey(num))
            {
                dictionary1.Add(num, 1);
            }
        }

        foreach (int num in nums2)
        {
            if (dictionary1.ContainsKey(num) && !dictionary2.ContainsKey(num))
            {
                result.Add(num);
                dictionary2.Add(num, 1);
            }
        }
        return result.ToArray();
    }
}

/* Second solution with a hash-set, cleaner */

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int< (nums1);
        var result = new HashSet<int>();

        foreach (int num in nums2)
        {
            if (!set1.Contains(num))
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }
}

// Time Complexity: O(n + m)
// Space Complexity: O(n + m)