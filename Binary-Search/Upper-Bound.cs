/*
Given a sorted array of nums and an integer x, write a program to find
the upper bound of x. The upper bound algorithm finds the first or the
smallest index in a sorted array where the value at that index is greater
than a given key i.e. x.
*/

public static int UpperBound(int[] arr, int x)
{
    int left = 0, right = arr.Length;

    while (left < right)
    {
        int mid = left + (right - left) / 2;
        /*
            We're skipping all values that are ≤ x, because upper bound looks
            for the first value greater than x
        */
        if (arr[mid] <= x)
        {
            left = mid + 1;
        }
        else
        {
            right = mid;
        }
    }

    return left;
}

// Time Complexity --> O(log n)
// Space Complexity --> O(1)
