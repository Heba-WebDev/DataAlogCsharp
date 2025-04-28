/*
Problem statement: Given two sorted arrays arr1[] and arr2[] of sizes n and m in non-decreasing order.
Merge them in sorted order. Modify arr1 so that it contains the first N elements and modify arr2 so
that it contains the last M elements.
*/

// Two pointers approach

using System;
using System.Linq;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 4, 8, 10 };
        int[] arr2 = { 2, 3, 9 };
        MergeTwoSortedArraysWithoutExtraSpace(arr1, arr2);
    }

    public static void MergeTwoSortedArraysWithoutExtraSpace(int[] arr1, int[] arr2)
    {

        int p1 = arr1.Length - 1;
        int p2 = 0;

        while (p1 >= 0 && p2 < arr2.Length)
        {
            if (arr1[p1] > arr2[p2])
            {
                int temp = arr1[p1];
                arr1[p1] = arr2[p2];
                arr2[p2] = temp;
                p1--;
                p2++;
            }
            else
            {
                break;
            }
        }
        Array.Sort(arr1);
        Array.Sort(arr2);
        Console.WriteLine(string.Join(", ", arr1));
        Console.WriteLine(string.Join(", ", arr2));

    }
}

/*
Time Complexity: O(n + m) + O(n log n) + O(m log m)
Space Complexity: O(1)
*/

// Gap method approach -> soon

