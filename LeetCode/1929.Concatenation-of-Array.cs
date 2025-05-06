/*
1929. Concatenation of Array
Arrays (in C# Linq is an overhead that might slow performance in larger arrays)
*/

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] result = new int[2 * n];
        
        for(int i = 0;  i < n; i++)
        {
            result[i] = nums[i];
            result[i + n] = nums[i];
        }

        return result;
    }

}

// Time Complexity: O(n)
// Space Complexity: O(n) -> a new array of size 2n → O(n) in terms of input size (not output size)
// 2 is a constant, and constants are dropped when we calculate complexity