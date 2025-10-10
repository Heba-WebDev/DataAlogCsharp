/*
14. Longest Common Prefix
strings and loops
*/

/*  Horizontal scan/comparison */
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") return "";
            }
        }

        return prefix;
    }
}

/*
Explanation: We start with the first string as the initial guess for the common prefix.
Then we check it against each other string in the list.

If the current string doesn’t start with that prefix, we shorten the prefix (remove characters
from the end) until it matches — or until nothing is left.
*/

// Time Complexity: O(n) --> we loop every single character at worst case
// Space Complexity: O(m) --> m being the length of the prefix

/*  Vertical scan/comparison */

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        for (int i = 0; i < strs[0].Length; i++)
        {
            char currentChar = strs[0][i];

            for (int j = 1; j < strs.Length; j++)
            { // stops immediately when a mismatch is found
              // only checks one column (i) at a time and exits early
                if (i == strs[j].Length || strs[j][i] != currentChar)
                    return strs[0].Substring(0, i);
            }
        }

        return strs[0];
    }
}
// Time Complexity: O(n)
// Space Complexity: O(1) --> no extra storage beyond loop variables