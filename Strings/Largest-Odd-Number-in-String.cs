/*

1903. Largest Odd Number in a String

You are given a string num, representing a large integer.
Return the largest-valued odd integer (as a string) that is
a non-empty substring of num, or an empty string "" if no odd
integer exists.

A substring is a contiguous sequence of characters within a string.

*/

public class Solution
{
    public string LargestOddNumber(string num)
    {
        // loop from the back to find an odd number
        for (int i = num.Length - 1; i >= 0; i--)
        {
            int digit = num[i] - '0'; // convert char to int
            if (digit % 2 != 0)
            {
                return num.substring(0, i + 1);
            }
        }

        return "";
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)
