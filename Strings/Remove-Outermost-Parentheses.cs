/*

1021. Remove Outermost Parentheses

You are given a valid string of parentheses. Each "primitive group" has an extra
outer pair of parentheses. Your job is to remove those outermost pairs and return
the remaining string. *reworded*

*/

public class Solution
{
    public string RemoveOuterParentheses(string s)
    {
        StringBuilder result = new StringBuilder();
        int level = 0;

        foreach (char x in s)
        {
            if (x == '(')
            {
                if (level > 0) result.Append(x);
                level++;
            }
            else if (x == ')')
            {
                level--;
                if (level > 0) result.Append(x);
            }
        }

        return result.ToString();
    }
}

// Time Complexity: O(n)
// Space Complexity: O(n)
