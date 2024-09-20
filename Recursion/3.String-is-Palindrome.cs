/*
Problem Statement: "Given a string, check if the string is palindrome
or not."  A string is said to be palindrome if the reverse of the
string is the same as the string.
*/

// With pointers
bool isPalindrome(string str)
{
    int p1 = 0;
    int p2 = str.Length - 1;
    while (p1 < p2)
    {
        char strP1 = char.ToLower(str[p1]);
        char strP2 = char.ToLower(str[p2]);

        if (strP1 != strP2)
        {
            return false;
        }
        p1++;
        p2--;
    }
    return true;
}

/*
Time complexity: O(n), where n is the length of the string
Space complexity: O(1)
*/