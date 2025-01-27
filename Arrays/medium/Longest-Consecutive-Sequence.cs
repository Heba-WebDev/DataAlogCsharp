/*
You are given an array of ‘N’ integers. You need to find the length
of the longest sequence which contains the consecutive elements.
EX: 1, 2, 3, 4 -> consecutive elements
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 100, 200, 1, 3, 2, 4 };
        Console.WriteLine(LongestConsecutiveSequence(arr));
    }

    public static int LongestConsecutiveSequence(int[] arr)
    {
        // HashSet for O(1) lookups
        var numSet = new HashSet<int>(arr);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // start of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}

// Time Complexity: O(N) Each number is processed at most twice (once when checking if it's a sequence starter and once when counting the sequence length)
// Space Complexity: O(N) The HashSet<T> stores all elements of the array
