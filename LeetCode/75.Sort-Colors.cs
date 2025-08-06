/*
75. Sort Colors (Medium) Three pointers

Given an array nums with n objects colored red, white, or blue, sort them in-plac
so that objects of the same color are adjacent, with the colors in the order red,
white, and blue.

We will use the integers 0, 1, and 2 to represent the color red, white, and blue,
respectively.

You must solve this problem without using the library's sort function.
*/

public class Solution
{
    public void SortColors(int[] nums)
    {
        int low = 0, mid = 0, high = nums.Length - 1;
        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                (nums[low], nums[mid]) = (nums[mid], nums[low]);
                low++;
                mid++;
            }
            else if (nums[mid] == 1)
            {
                mid++;
            }
            else
            {
                (nums[mid], nums[high]) = (nums[high], nums[mid]);
                high--;
            }
        }
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)