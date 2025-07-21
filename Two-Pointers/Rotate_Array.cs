/*
189. Rotate Array

Given an integer array nums, rotate the array to the right by k steps,
where k is non-negative.

Follow up:

- Try to come up with as many solutions as you can. There are at least three
different ways to solve this problem.

- Could you do it in-place with O(1) extra space?
*/

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n; // normalize k, to never have out of bound/array.length error

        // reverse the whole array
        Reverse(nums, 0, n - 1);

        // reverse the first k elements
        Reverse(nums, 0, k - 1);

        // reverse the rest
        Reverse(nums, k, n - 1);

    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
            left++;
            right--;
        }
    }
}

// Time Complexity: O(n)

// Space Complexity: O(1)

/*

Time complexity explanation:

First reverse: reverses the full array → O(n)

Second reverse: reverses k elements → O(k)

Third reverse: reverses n - k elements → O(n - k)

O(n) + O(k) + O(n - k) = O(n) + O(n) = O(2n)

we dropped the constants 2, simplified to O(n)

*/