/*
Insertion sort is a simple sorting algorithm that builds the
final sorted array (or list) one item at a time by comparisons.
It is much less efficient on large lists than more advanced algorithms
such as quicksort, heapsort, or merge sort.
*/

public static void Main(string[] args)
{
    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
    Insertion(arr);
    Console.WriteLine("Sorted array: " + string.Join(", ", arr));
}

public static void Insertion(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = i; j > 0; j--)
        {
            if (arr[j] < arr[j - 1])
            {
                var temp = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = temp;
            }
            else
            {
                break;
            }
        }
    }
}