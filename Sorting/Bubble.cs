/*
Bubble Sort is the simplest sorting algorithm that works by repeatedly
swapping the adjacent elements if they are in the wrong order. This
algorithm is not suitable for large data sets as its average and worst-case
time complexity are quite high.
*/

public static void Bubble(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        bool swap = false; // optimization
        for (int j = 0; j <= i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                var temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swap = true;
            }
        }
        if (!swap) break;
    }
}