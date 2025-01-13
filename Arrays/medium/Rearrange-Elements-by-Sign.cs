/*
Variety-1

There’s an array ‘A’ of size ‘N’ with an equal number of positive
and negative elements. Without altering the relative order of positive
and negative elements, you must return an array of alternately positive
and negative values.

Note: Start the array with positive elements.

Variety-2
There’s an array ‘A’ of size ‘N’ with positive and negative elements
(not necessarily equal). Without altering the relative order of positive
and negative elements, you must return an array of alternately positive
and negative values. The leftover elements should be placed at the very
end in the same order as in array A.
Note: Start the array with positive elements.
*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, -3, -1, -2, -3 };
        var result = RearrangeBySign(arr);
        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] RearrangeBySign(int[] arr)
    {
        int pos_index = 0;
        int neg_index = 1;
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && pos_index < arr.Length) // the && statement is for arrays without equal positive and negative numbers
            {
                newArr[pos_index] = arr[i];
                pos_index += 2;
            }
            else if (arr[i] < 0 && neg_index < arr.Length)
            {
                newArr[neg_index] = arr[i];
                neg_index += 2;
            }
        }
        return newArr;
    }
}

// Time Complexity: O(n) and Space Complexity: O(n)