/*
796. Rotate String

Given two strings s and goal, return true if and only if s can
become goal after some number of shifts on s. A shift on s consists
of moving the leftmost character of s to the rightmost position.
*/

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;

        for (int i = 0; i < s.Length; i++)
        {
            string rotated = s[1..] + s[0];

            if (rotated == goal) return true;

            s = rotated;
        }

        return false;
    }
}

// Time Complexity: O(n²) — Substring() and string concatenation each take O(n) per rotation
// Space Complexity: O(n) - for the rotated string copies

/* ---- */

/*
Shorter solution with the same time and space complexity
*/

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;
        return (s + s).Contains(goal);
    }
}
