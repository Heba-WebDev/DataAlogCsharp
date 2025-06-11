/*
You are given a sorted array consisting of only integers where every
element appears exactly twice, except for one element which appears
exactly once.

Return the single element that appears only once.

Your solution must run in O(log n) time and O(1) space.

Approcach: We can check the mid and see if the left/right sides have an odd or even
number of element and go with the side that has the odd number (pairs + single element)
But there's a better apprach that takes advantage of the index pairing. What it does is
that before the single element appears, the first occurance of a pair is in an even index
but after the single element appear, the first occurance of the pair is in an odd index
*/

// Approach: Index Parity
public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            // ensure mid is even so it represents the first index of a pair
            if (mid % 2 == 1)
            {
                mid--;
            }

            if (nums[mid] == nums[mid + 1]) // mid even, so single element on the right
            {
                left = mid + 2;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left]; // left == right at the end
    }
}

// Approach: Manual Count-Based Halving

// you check the number of element and and based on that go left or right

public class Solution
{
    public int SingleNonDuplicate(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (mid > 0 && nums[mid] == nums[mid - 1])
            {

                int leftCount = mid - 1 - left; // can also be right side,
                // doesn't matter, we just want the side with odd elements to
                // go with

                if (leftCount % 2 == 0)
                {
                    // left side is even, drop left half before mid
                    left = mid + 1;
                }
                else
                {
                    // left side is odd, drop right side after mid
                    right = mid - 2;
                }

            }
            else if (mid < nums.Length - 1 && nums[mid] == nums[mid + 1])
            {

                int leftCount = mid - left;

                if (leftCount % 2 == 0)
                {
                    left = mid + 2;
                }
                else
                {
                    right = mid - 1;
                }

            }
            else
            {
                // nums[mid] is the unique element
                return nums[mid];
            }
        }

        return nums[left];
    }
}


