/*
Given a string s, find the length of the
longest substring without duplicate characters.

Approach:

- Sliding window with two pointers (left and right) to represent the current window.
- Hash set to keep track of the characters in the current window.
- Move the right pointer to expand the window and add characters to the set.
- If a duplicate character is found, move the left pointer to the right of the previous occurrence
of the duplicate character, adjusting the set accordingly.
- Keep track of the maximum length of the window encountered.

*/

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        int max = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            max = Math.Max(max, right - left + 1);
        }
        return max;
    }
}
