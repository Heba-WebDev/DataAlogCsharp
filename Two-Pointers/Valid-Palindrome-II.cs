/*
680. Valid Palindrome II

Given a string s, return true if the s can be palindrome after deleting
at most one character from it.
*/

public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return ValidateS(s, left + 1, right) || ValidateS(s, left, right - 1);
            }

            left++;
            right--;
        }
        return true;
    }

    private bool ValidateS(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }

        return true;
    }
}