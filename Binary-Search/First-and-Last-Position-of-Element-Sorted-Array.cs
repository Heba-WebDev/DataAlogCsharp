/*
Given an array of integers nums sorted in non-decreasing order,
find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirst(nums, target);
        int last = FindLast(nums, target);
        return new int[] { first, last };
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int index = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                index = mid;
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return index;
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int index = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                index = mid;
                left = mid + 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return index;
    }
}

// Time Complexity: O(log n)
// Space Complexity: O(1)
