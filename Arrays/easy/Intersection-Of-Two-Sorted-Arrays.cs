/*
Find the common numbers between a two sorted arrays.
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 1, 3, 4, 5, 7, 8, 9 };

        var result = IntersectionOfTwoSortedArray(arr1, arr2, arr1.Length, arr2.Length);
        Console.WriteLine(string.Join(", ", result));
    }

    public static List<int> IntersectionOfTwoSortedArray(int[] arr1, int[] arr2, int n, int m)
    {
        List<int> intersection = new List<int>();

        int pointer1 = 0;
        int pointer2 = 0;

        while (pointer1 < n && pointer2 < m)
        {
            if (arr1[pointer1] == arr2[pointer2])
            {
                if (intersection.Count == 0 || intersection[^1] != arr1[pointer1])
                    intersection.Add(arr1[pointer1]);
                pointer1++;
                pointer2++;
            }
            else if (arr1[pointer1] < arr2[pointer2])
            {
                pointer1++;
            }
            else
            {
                pointer2++;
            }
        }
        return intersection;
    }
}

/*
Time Complexity: O(n + m)
Space Complexity: O(k), where k is the size of the intersection list
*/