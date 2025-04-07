/*
Given an array of N integers. Find the elements that appear more
than N/3 times in the array. If no such element exists, return an
empty vector.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Arrays
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 2, 3, 2 };
        var result = MajorityElements(arr);
        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] MajorityElements(int[] arr)
    {
        int n = arr.Length / 3;
        List<int> list = new List<int>();
        var hash = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (hash.ContainsKey(num))
            {
                hash[num]++;
            }
            else
            {
                hash[num] = 1;
            }

            if (hash[num] > n && !list.Contains(num))
            {
                list.Add(num);
            }
        }

        return list.ToArray();
    }
}