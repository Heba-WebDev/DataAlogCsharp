/*
Given a sorted array of nums and an integer x, write a program to find the
lower bound of x. The lower bound algorithm finds the first or the smallest
index in a sorted array where the value at that index is greater than or equal
to a given key i.e. x.

If no such index is found, return the size of the array.
*/

public static int LowerBound(int[] arr, int x)
{
    int left = 0, right = arr.Length;

    while (left < right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] < x)
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

/*
NOTE: The loop guarantees that left ends up pointing to the first valid index,
or the array’s end if none is valid.
*/