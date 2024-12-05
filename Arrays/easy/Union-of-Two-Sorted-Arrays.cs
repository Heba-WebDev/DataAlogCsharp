/*
Given two sorted arrays, arr1, and arr2 of size n and m.
Find the union of two sorted arrays.
The union of two arrays can be defined as the common and distinct
elements in the two arrays.
----
NOTE: Elements in the union should be in ascending order.
*/

using System;
using System.Collections.Generic;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 1, 3, 4, 5, 7, 8, 9 };

        var result = UnionTwoSortedArray(arr1, arr2, arr1.Length, arr2.Length);
        Console.WriteLine(string.Join(", ", result));
    }

    public static List<int> UnionTwoSortedArray(int[] arr1, int[] arr2, int n, int m)
    {
        List<int> union = new List<int>();

        int pointer1 = 0;
        int pointer2 = 0;

        while (pointer1 < n && pointer2 < m)
        {
            if (arr1[pointer1] < arr2[pointer2])
            {
                // Add element if not already in the list
                if (union.Count == 0 || union[^1] != arr1[pointer1])
                    union.Add(arr1[pointer1]);
                pointer1++;
            }
            else if (arr1[pointer1] > arr2[pointer2])
            {
                if (union.Count == 0 || union[^1] != arr2[pointer2])
                    union.Add(arr2[pointer2]);
                pointer2++;
            }
            else
            {
                // Both elements are equal
                if (union.Count == 0 || union[^1] != arr1[pointer1])
                    union.Add(arr1[pointer1]);
                pointer1++;
                pointer2++;
            }
        }

        // Add remaining elements from arr1
        while (pointer1 < n)
        {
            if (union.Count == 0 || union[^1] != arr1[pointer1])
                union.Add(arr1[pointer1]);
            pointer1++;
        }

        // Add remaining elements from arr2
        while (pointer2 < m)
        {
            if (union.Count == 0 || union[^1] != arr2[pointer2])
                union.Add(arr2[pointer2]);
            pointer2++;
        }

        return union;
    }
}

/*
union[^1] retrieves the last element of the union list.
The condition checks if:
The union list is empty (union.Count == 0) — no elements added yet.
The last added element (union[^1]) is not equal to the current value being processed (arr1[pointer1] or arr2[pointer2]).
This ensures no duplicate values are added to the union list.
*/