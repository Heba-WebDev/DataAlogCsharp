/*
Merge sort is an efficient, general-purpose, and comparison-based
sorting algorithm. Most implementations produce a stable sort
(a stable sorting algorithm maintains the relative order of the
items with equal sort keys). Merge sort is a divide-and-conquer algorithm.
*/

public class Sort
{
    public static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", arr));

        MergeSort(arr);

        Console.WriteLine("\nSorted array:");
        Console.WriteLine(string.Join(", ", arr));
    }

    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];
        // Array.Copy(sourceArray, sourceStartIndex, destinationArray, destinationStartIndex, length)
        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);
        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    public static void Merge(int[] arr, int[] left, int[] right)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int targetIndex = 0;

        // Compare and merge while both arrays have elements
        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                arr[targetIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[targetIndex] = right[rightIndex];
                rightIndex++;
            }
            targetIndex++;
        }

        // Copy the remaining elements
        while (leftIndex < left.Length)
        {
            arr[targetIndex] = left[leftIndex];
            leftIndex++;
            targetIndex++;
        }

        while (rightIndex < right.Length)
        {
            arr[targetIndex] = right[rightIndex];
            rightIndex++;
            targetIndex++;
        }
    }
}

// Time complexity O(n log n) - Space complexity O(n)