/*
Given an array, find the second smallest element in the array.
Print ‘-1’ in the event it doesn’t exist.
*/

public class Arrays
{
    public static void Main(string[] args)
    {
        int[] arr = { 8, 5, 2, 7, 9, 3, 10 };
        Console.WriteLine(SecondSmallestElement(arr));
    }

    public static int SecondSmallestElement(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new InvalidOperationException("Array must have at least two elements.");
        }

        int smallest = int.MaxValue;
        int second_smallest = int.MaxValue;

        foreach (int num in arr)
        {
            if (num < smallest)
            {
                second_smallest = smallest;
                smallest = num;
            }
            else if (num > smallest && num < second_smallest)
            {
                second_smallest = num;
            }
        }
        if (second_smallest == int.MaxValue)
        {
            throw new InvalidOperationException("No distinct second smallest element found.");
        }

        return second_smallest;
    }
}
