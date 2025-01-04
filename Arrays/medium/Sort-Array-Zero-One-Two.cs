/*
Given an array consisting of only 0s, 1s, and 2s.
Write a program to in-place sort the array without using
inbuilt sort functions.
---
Dutch Flag Algorithm (DFA) is one of the most basic and important
algorithms for arrays. It is used to segregate an array consisting
of 3 numbers in linear time complexity. The worst time complexity
for DFA is O(n) and the space complexity for the algorithm is O(1).
---
The rules:
[0 ... low-1] -> 0
[low ... mid-1] -> 1
[high+1 ... n-1] -> 2
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 0, 2, 1, 1, 0 };
        SortArrayOfZeroOneTwo(arr, arr.Length);
    }

    public static void SortArrayOfZeroOneTwo(int[] arr, int n)
    {
        int low = 0;
        int mid = 0;
        int high = n - 1;
        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                int temp = arr[low];
                arr[low] = arr[mid];
                arr[mid] = temp;
                low++;
                mid++;
            }
            else if (arr[mid] == 1)
            {
                mid++;
            }
            else
            {
                int temp = arr[mid];
                arr[mid] = arr[high];
                arr[high] = temp;
                high--;
            }
        }
        Console.WriteLine(string.Join(", ", arr));
    }
}

// Time Complexity: O(n) * one elements gets sorted in each loop iteration and either mid moves or high shrinks
// Space Compelxity: O(1) *in place sorting