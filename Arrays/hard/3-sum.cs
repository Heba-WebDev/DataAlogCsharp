public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {

        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

        }

        return result;
    }
}

/*
Time Complexity: O(n²)
O(n log n) (for sorting) + O(n * n) (for the two-pointer scan).
Which simplifies to O(n²) (since it's the dominant term)
----
Space Complexity: O(k)
where k is the number of valid triplets (can be up to O(n²) in worst case).
*/