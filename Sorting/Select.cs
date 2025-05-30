/*
The algorithm divides the input list into two parts: a sorted sublist
of items which is built up from left to right at the front (left) of
the list and a sublist of the remaining unsorted items that occupy the
rest of the list. Initially, the sorted sublist is empty and the unsorted
sublist is the entire input list. The algorithm proceeds by finding the
smallest (or largest, depending on sorting order) element in the unsorted
sublist, exchanging (swapping) it with the leftmost unsorted element
(putting it in sorted order), and moving the sublist boundaries one element
to the right.
*/

for (int i = 0; i < arr.Length; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] < arr[minIndex]) minIndex = j;
    }
    if (minIndex != i)
    {
        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
}