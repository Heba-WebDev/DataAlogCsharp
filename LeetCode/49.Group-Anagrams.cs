/*
49. Group Anagrams
Approach: Sorting and Array-Hash
*/

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sortedWord = new string(chars);

            if (dictionary.ContainsKey(sortedWord))
            {
                dictionary[sortedWord].Add(word);
            }
            else
            {
                dictionary.Add(sortedWord, new List<string> { word });
            }
        }


        IList<IList<string>> result = new List<IList<string>>();
        foreach (var group in dictionary.Values)
        {
            result.Add(group);
        }

        return result;
    }
}

// Time Complexity: O(N * K log K) --> k is the maximum length of a word,
// sorting it takes k log k and n is the length of the list/array

// Space Complexity: O(N * K) --> N is the number of strings in the input array strs
// and K is the maximum length of a string in strs
