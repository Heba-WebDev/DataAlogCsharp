/*
Problem Statement: Given an array of intervals (a jagged array), merge all the overlapping
intervals and return an array of non-overlapping intervals.
*/

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        int[] prev = intervals[0];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (prev[1] >= intervals[i][0])
            {
                prev[1] = Math.Max(prev[1], intervals[i][1]);
            }
            else
            {
                result.Add(prev);
                prev = intervals[i];
            }
        }
        result.Add(prev);
        return result.ToArray();

    }
}

/*
Time Complexity: O(n log n)
Space Complexity: O(n) -> no intervals overlap, we store all intervals in the list
*/