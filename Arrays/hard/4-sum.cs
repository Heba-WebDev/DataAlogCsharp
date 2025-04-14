/*
Given an array nums of n integers, return an array of all the
unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:

0 <= a, b, c, d < n
a, b, c, and d are distinct.
nums[a] + nums[b] + nums[c] + nums[d] == target
You may return the answer in any order.
*/

// Naive solution, 3 sum solution + 1 loop

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                int left = j + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }
        return result;
    }
}

/*
Time Complexity: O(n³)
Space Complexity: Depends on how many quadruplets you find, worst case O(n³).
*/

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        return KSum(nums, 0, 4, target);
    }

    private IList<IList<int>> KSum(int[] nums, int start, int k, long target)
    {
        IList<IList<int>> res = new List<IList<int>>();

        if (k == 2)
        {
            return TwoSum(nums, start, target);
        }

        for (int i = start; i < nums.Length - k + 1; i++)
        {
            if (i > start && nums[i] == nums[i - 1]) continue;
            //  avoid recursion when it's mathematically impossible
            if ((long)nums[i] + (long)nums[nums.Length - 1] * (k - 1) < target) continue;
            if ((long)nums[i] + (long)nums[i + 1] * (k - 1) > target) break;
            //  try to find k - 1 numbers that sum to target - nums[i]
            var subResults = KSum(nums, i + 1, k - 1, target - nums[i]);

            foreach (var subset in subResults)
            {
                var current = new List<int> { nums[i] };
                current.AddRange(subset);
                res.Add(current);
            }
        }
        return res;
    }

    private IList<IList<int>> TwoSum(int[] nums, int start, long target)
    {
        IList<IList<int>> res = new List<IList<int>>();
        int left = start, right = nums.Length - 1;

        while (left < right)
        {
            long sum = (long)nums[left] + nums[right];

            if (sum == target)
            {
                res.Add(new List<int> { nums[left], nums[right] });

                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;

                left++;
                right--;
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return res;
    }
}

/*
Time Complexity: O(n³) -> 2 loops + 2 pointers = O(n²) * O(n) = O(n³)
Space Complexity: O(k) -> Where k is number of valid results
*/