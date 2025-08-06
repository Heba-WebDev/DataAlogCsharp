/*

219. Contains Duplicate II

Given an integer array nums and an integer k, return true if there are two distinct indices
i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.


*/

using System.Collections.Generic;

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i]))
                return true;

            set.Add(nums[i]);

            if (set.Count > k)
                set.Remove(nums[i - k]);
        }

        return false;
    }
}

// Time Complexity: O(n)

// Space Complexity: O(k)
