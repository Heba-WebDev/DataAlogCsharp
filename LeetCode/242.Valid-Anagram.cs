/*
242. Valid Anagram
Arrays-Hash
*/

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var count = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!count.ContainsKey(c))
                count[c] = 0;
            count[c]++;
        }

        foreach (char c in t)
        {
            if (!count.ContainsKey(c))
                return false;

            count[c]--;
            if (count[c] < 0)
                return false;
        }

        return true;
    }
}

// Time Complexity: O(n) --> n is the length of the strings
// Space Complexity: O(1) -->  though we use a dictionary, the space is bounded (at most 26 lowercase English letters)