/*
451. Sort Characters By Frequency

Given a string s, sort it in decreasing order based on the frequency
of the characters. The frequency of a character is the number of times
it appears in the string.

Return the sorted string. If there are multiple answers, return any of
them.
*/

using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public static string FrequencySort(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (freq.ContainsKey(c))
            {
                freq[c]++;
            }
            else
            {
                freq[c] = 1;
            }
        }

        var sorted = freq.OrderByDescending(x => x.Value);

        return string.Concat(sorted.Select(x => new string(x.Key, x.Value)));
    }
}

// Time Complexity: O(n log k), where k is number of unique characters (because of sorting)
// Space Complexity: O(k)
