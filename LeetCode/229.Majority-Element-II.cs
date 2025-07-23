/*
229. Majority Element II (Medium)

Given an integer array of size n, find all elements that appear
more than ⌊ n/3 ⌋ times.
*/

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int? candidate1 = null, candidate2 = null;
        int count1 = 0, count2 = 0;

        // first pass to find potenial candidates
        foreach (int num in nums)
        {
            if (candidate1 == num)
            {
                count1++;
            } else if (candidate2 == num)
            {
                count2++;
            } else if (count1 == 0)
            {
                candidate1 = num;
                count1 = 1;
            } else if (count2 == 0)
            {
                candidate2 = num;
                count2 = 1;
            } else
            {
                count1--;
                count2--;
            }
        }

         // second pass: verify the candidates
            count1 = 0;
            count2 = 0;
             foreach (int num in nums)
             {
                if (num == candidate1)
                {
                     count1++;
                }
                else if (num == candidate2)
                {
                    count2++;
                }
             }
            var result = new List<int>();
            int n = nums.Length / 3;
            if (count1 > n) result.Add(candidate1.Value);
            if (count2 > n) result.Add(candidate2.Value);
            return result;
    }
}

// Time Complexity: O(n)

// Space Complexity: O(1) — excluding the output list