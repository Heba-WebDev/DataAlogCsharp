/*
169. Majority Element [Arrays Hashing]
*/

/* 1st try */

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int majority = nums.Length / 2;
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

            if (dictionary[num] > majority)
            {
                return num;
            }
        }

        return nums[0];
    }
}

// Time Complexity: O(n)
// Space Complexity: O(n)

/*
Follow-up: Could you solve the problem in linear time and in O(1) space?
Boyer-Moore Voting Algorithm, can only implemented if we're
guaranteed we have a majority element

Explanation:
We start with the first element as the result and we increment the count
If the next element is different but the count is more than 0, we decrement the count
If the count is zero, result will equal the current element and count = 1 instead of 0
*/

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int result = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                result = num;
            }

            count += (num == result) ? 1 : -1;
        }

        return result;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)