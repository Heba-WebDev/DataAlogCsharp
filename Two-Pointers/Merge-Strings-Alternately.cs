/*
1768. Merge Strings Alternately

You are given two strings word1 and word2. Merge the strings by adding letters in alternating order,
starting with word1. If a string is longer than the other, append the additional letters onto the end
of the merged string.

Return the merged string.

*/

// Solution 1 (my first approach)

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int pointer1 = 0;
        int pointer2 = 0;
        int index = 0;
        char[] result = new char[word1.Length + word2.Length];

        while (pointer1 < word1.Length && pointer2 < word2.Length)
        {
            result[index++] = word1[pointer1++];
            result[index++] = word2[pointer2++];
        }

        while (pointer1 < word1.Length)
        {
            result[index++] = word1[pointer1++];
        }

        while (pointer2 < word2.Length)
        {
            result[index++] = word2[pointer2++];
        }

        return new string(result);
    }
}


// Solution 2 (cleaner version)
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new StringBuilder();
        int i = 0, j = 0;

        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length) result.Append(word1[i++]);
            if (j < word2.Length) result.Append(word2[j++]);
        }

        return result.ToString();
    }
}