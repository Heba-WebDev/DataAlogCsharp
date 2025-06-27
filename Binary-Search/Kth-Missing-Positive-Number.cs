/*
1539. Kth Missing Positive Number

Given an array arr of positive integers sorted in a strictly increasing order,
and an integer k.
Return the kth positive integer that is missing from this array.
*/

public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            int missing = arr[middle] - 1 - middle;

            if (missing < k)
                left = middle + 1;
            else
                right = middle - 1;
        }

        return left + k;
    }
}

/*
The number of missing numbers before arr[i] is arr[i] - (i + 1) = arr[i] - 1 - i
---
Why left + k is the Answer:
- All elements before left have fewer than k missing numbers before them.

*/