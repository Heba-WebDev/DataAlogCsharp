/*
1614. Maximum Nesting Depth of the Parentheses

Given a valid parentheses string s, return the nesting depth of s.
The nesting depth is the maximum number of nested parentheses.
*/

public class Solution
{
    public int MaxDepth(string s)
    {
        int currentDepth = 0;
        int maxDepth = 0;

        foreach (char c in s)
        {
            if (c == '(')
            {
                currentDepth++;
                maxDepth = Math.Max(maxDepth, currentDepth);
            }
            else if (c == ')')
            {
                currentDepth--;
            }
        }

        return maxDepth;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)