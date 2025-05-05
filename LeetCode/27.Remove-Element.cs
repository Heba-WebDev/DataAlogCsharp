/*
27. Remove Element
*/

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                // when we find a num != val, we copy it to position k and increment k
                // this way the first k elements are those who are not equal to val
                // problem does not care about what comes after k elements
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
