/*
QuickSort is a sorting algorithm based on the Divide
and Conquer that picks an element as a pivot and partitions
the given array around the picked pivot by placing the pivot
in its correct position in the sorted array.
*/

public class QuickSort
{
    public static void Main()
    {
        int[] arr = { 34, 7, 23, 32, 5, 62 };
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(", ", arr));

        quickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array:");
        Console.WriteLine(string.Join(", ", arr));
    }
    public static void quickSort(int[] arr, int lowIndex, int highIndex)
    {
        if (lowIndex >= highIndex) return;
        int pivot = arr[highIndex];
        int leftPointer = lowIndex;
        int rightPointer = highIndex;

        while (leftPointer < rightPointer)
        {
            while(arr[leftPointer] <= pivot && leftPointer < rightPointer)
            {
                leftPointer++;
            }
            while (arr[rightPointer] >= pivot && leftPointer < rightPointer)
            {
                rightPointer--;
            }
            // now the two inner loops points to a left element
            // that is smaller and a right element that is bigger
            // it's time to swap
            swap(arr, leftPointer, rightPointer);
        }
        swap(arr, leftPointer, highIndex);
        quickSort(arr, lowIndex, leftPointer - 1);
        quickSort(arr, leftPointer + 1, highIndex);
    }

    public static void swap(int arr[], int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}