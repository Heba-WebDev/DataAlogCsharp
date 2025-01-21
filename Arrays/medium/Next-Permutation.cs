/*
Given an array Arr[] of integers, rearrange the numbers of
the given array into the lexicographically next greater
permutation of numbers.
----
NOTE: If such an arrangement is not possible, it must rearrange
to the lowest possible order (i.e., sorted in ascending order
*reverse the number basically*).
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 3, 2 };
        Console.WriteLine(string.Join(", ", arr));
        NextPermutation(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    public static void NextPermutation(int[] nums)
    {
        if (nums == null || nums.Length <= 1) return;

        int i = nums.Length - 2;
        // find first decreasing element from right
        while (i >= 0 && nums[i] >= nums[i + 1])
        {
            i--;
        }
        if (i >= 0) // we found the element
        {
            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }
            Swap(nums, i, j);
        }
        Reverse(nums, i + 1);
    }

    private static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private static void Reverse(int[] nums, int start)
    {
        int i = start, j = nums.Length - 1;
        while (i < j)
        {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)